// <copyright file="GetPersonsController.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Controllers.Persons
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using ROP;

    [Authorize]
    [Route("Persons")]
    public class GetPersonsController : Controller
    {
        private readonly ISearchPersonsUseCase searchPersonsUseCase;

        public GetPersonsController(ISearchPersonsUseCase searchPersonsUseCase)
        {
            this.searchPersonsUseCase = searchPersonsUseCase;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index([FromQuery] PersonSearchCriteria criteria)
        {
            Result<PersonSearchViewModel> result = await this.searchPersonsUseCase.Execute(criteria)
                .ConfigureAwait(false);

            PersonSearchViewModel personSearchViewModel = new PersonSearchViewModel();

            if (!result.Errors.Any())
            {
                personSearchViewModel = result.Value;
            }

            return this.View("~/Views/Persons/Index.cshtml", personSearchViewModel);
        }
    }
}
