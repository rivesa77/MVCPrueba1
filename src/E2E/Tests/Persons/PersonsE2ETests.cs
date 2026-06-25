// <copyright file="PersonsE2ETests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.E2E.Tests.Persons
{
    using System.Net;
    using System.Text.RegularExpressions;
    using Microsoft.EntityFrameworkCore;
    using Ricardo.MVCPrueba1.Infrastructure.Data;

    [TestClass]
    [TestCategory("E2E.Persons")]
    public class PersonsE2ETests
    {
        private static readonly Uri BaseUri = new Uri(
            Environment.GetEnvironmentVariable("E2E_BASE_URL") ?? "https://localhost:7097");

        [TestMethod]
        public async Task Persons_WhenCreated_CanBeSearchedAndSortedByNameDescending()
        {
            using HttpClient client = CreateHttpClient();
            string uniqueId = Guid.NewGuid().ToString("N")[..8];
            string searchTerm = $"E2E {uniqueId}";
            string aliceName = $"{searchTerm} Alice";
            string zedName = $"{searchTerm} Zed";
            bool cleanupRequired = false;

            try
            {
                await RegisterUser(client, uniqueId).ConfigureAwait(false);
                cleanupRequired = true;

                await CreatePerson(client, "80000001A", aliceName, $"alice.{uniqueId}@example.com", "600300001").ConfigureAwait(false);
                await CreatePerson(client, "80000002B", zedName, $"zed.{uniqueId}@example.com", "600300002").ConfigureAwait(false);

                string personsPage = await GetStringOrInconclusive(
                    client,
                    $"/Persons?searchField=Name&searchTerm={Uri.EscapeDataString(searchTerm)}&pageSize=5&sortField=Name&sortDirection=Descending")
                    .ConfigureAwait(false);

                StringAssert.Contains(personsPage, zedName);
                StringAssert.Contains(personsPage, aliceName);

                Assert.IsTrue(
                    personsPage.IndexOf(zedName, StringComparison.Ordinal) < personsPage.IndexOf(aliceName, StringComparison.Ordinal),
                    "Expected the Zed person to appear before the Alice person when sorting by name descending.");
            }
            finally
            {
                if (cleanupRequired)
                {
                    await CleanupTestData(uniqueId).ConfigureAwait(false);
                }
            }
        }

        private static HttpClient CreateHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false,
                CookieContainer = new CookieContainer(),
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
            };

            return new HttpClient(handler)
            {
                BaseAddress = BaseUri,
                Timeout = TimeSpan.FromSeconds(20),
            };
        }

        private static async Task RegisterUser(HttpClient client, string uniqueId)
        {
            string registerPage = await GetStringOrInconclusive(client, "/Identity/Account/Register").ConfigureAwait(false);
            string token = GetAntiForgeryToken(registerPage);

            using HttpResponseMessage response = await client.PostAsync(
                "/Identity/Account/Register",
                new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                    ["Input.Email"] = $"e2e.{uniqueId}@example.com",
                    ["Input.Password"] = "E2eTest1234!",
                    ["Input.ConfirmPassword"] = "E2eTest1234!",
                    ["__RequestVerificationToken"] = token,
                }))
                .ConfigureAwait(false);

            Assert.IsTrue(
                response.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.SeeOther,
                $"Expected register to redirect after success, but received {(int)response.StatusCode}.");
        }

        private static async Task CreatePerson(HttpClient client, string dni, string name, string email, string phone)
        {
            using HttpResponseMessage response = await client.PostAsync(
                "/Persons/create",
                new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                    ["DNI"] = dni,
                    ["Name"] = name,
                    ["Email"] = email,
                    ["Phone"] = phone,
                }))
                .ConfigureAwait(false);

            Assert.IsTrue(
                response.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.SeeOther,
                $"Expected person create to redirect after success, but received {(int)response.StatusCode}.");
        }

        private static async Task<string> GetStringOrInconclusive(HttpClient client, string path)
        {
            try
            {
                using HttpResponseMessage response = await client.GetAsync(path).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    Assert.Inconclusive(
                        $"E2E app is not ready at {BaseUri}. GET {path} returned {(int)response.StatusCode}.");
                }

                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (HttpRequestException exception)
            {
                Assert.Inconclusive($"E2E app is not available at {BaseUri}: {exception.Message}");
                throw;
            }
            catch (TaskCanceledException exception)
            {
                Assert.Inconclusive($"E2E app did not respond at {BaseUri}: {exception.Message}");
                throw;
            }
        }

        private static string GetAntiForgeryToken(string html)
        {
            Match match = Regex.Match(
                html,
                "name=\"__RequestVerificationToken\"[^>]*value=\"(?<token>[^\"]+)\"|value=\"(?<token>[^\"]+)\"[^>]*name=\"__RequestVerificationToken\"",
                RegexOptions.IgnoreCase);

            Assert.IsTrue(match.Success, "The antiforgery token was not found in the register page.");

            return WebUtility.HtmlDecode(match.Groups["token"].Value);
        }

        private static async Task CleanupTestData(string uniqueId)
        {
            DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(GetConnectionString())
                .Options;

            await using ApplicationDbContext context = new ApplicationDbContext(options);
            string userEmail = $"e2e.{uniqueId}@example.com";

            string[] personEmails =
            [
                $"alice.{uniqueId}@example.com",
                $"zed.{uniqueId}@example.com",
            ];

            context.Persons.RemoveRange(
                context.Persons.Where(person =>
                    person.Name.Contains(uniqueId)
                    || personEmails.Contains(person.Email)));

            Microsoft.AspNetCore.Identity.IdentityUser user = await context.Users
                .SingleOrDefaultAsync(identityUser => identityUser.Email == userEmail)
                .ConfigureAwait(false);

            if (user is not null)
            {
                context.Users.Remove(user);
            }

            await context.SaveChangesAsync().ConfigureAwait(false);
        }

        private static string GetConnectionString()
        {
            return Environment.GetEnvironmentVariable("E2E_CONNECTION_STRING")
                ?? "Server=(localdb)\\mssqllocaldb;Database=MVCPrueba1;Trusted_Connection=True;MultipleActiveResultSets=true";
        }
    }
}
