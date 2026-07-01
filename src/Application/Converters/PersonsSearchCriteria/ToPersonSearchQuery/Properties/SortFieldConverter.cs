// <copyright file="SortFieldConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class SortFieldConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        PersonSortField>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override PersonSortField GetPropertyValue(PersonSearchCriteria source)
        {
            return source.SortField;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, PersonSortField propertyValue)
        {
            result.SortField = propertyValue;
        }
    }
}
