// <copyright file="IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal interface IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter :
        IClassPropertyConverter<PersonSearchCriteria, PersonSearchQuery>
    {
    }
}