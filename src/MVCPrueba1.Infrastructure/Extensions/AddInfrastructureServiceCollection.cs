// <copyright file="AddInfrastructureServiceCollection.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using MVCPrueba1.Data;
    using MVCPrueba1.Data.Repositories;
    using MVCPrueba1.Logic.Repositories;
    using MVCPrueba1.Logic.UserInfo;

    public static class AddInfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddHttpContextAccessor();

            services
                .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IPersonUserDetails, PersonUserDetails>();

            return services;
        }
    }
}
