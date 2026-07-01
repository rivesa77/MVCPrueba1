// <copyright file="IPersonsSearchCriteriaToPersonSearchQueryConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal interface IPersonsSearchCriteriaToPersonSearchQueryConverter : IClassConverter<PersonSearchCriteria, PersonSearchQuery>
    {
    }
}