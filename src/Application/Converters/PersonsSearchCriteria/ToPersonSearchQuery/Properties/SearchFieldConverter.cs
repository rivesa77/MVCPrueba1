// <copyright file="SearchFieldConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class SearchFieldConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        PersonSearchField>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override PersonSearchField GetPropertyValue(PersonSearchCriteria source)
        {
            return source.SearchField;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, PersonSearchField propertyValue)
        {
            result.SearchField = propertyValue;
        }
    }
}