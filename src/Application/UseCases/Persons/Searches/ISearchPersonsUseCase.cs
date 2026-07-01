// <copyright file="ISearchPersonsUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface ISearchPersonsUseCase : IPersonUseCase<PersonSearchCriteria, PersonSearchViewModel>
    {
    }
}
