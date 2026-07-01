// <copyright file="SortDirectionConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class SortDirectionConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        PersonSortDirection>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override PersonSortDirection GetPropertyValue(PersonSearchCriteria source)
        {
            return source.SortDirection;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, PersonSortDirection propertyValue)
        {
            result.SortDirection = propertyValue;
        }
    }
}
