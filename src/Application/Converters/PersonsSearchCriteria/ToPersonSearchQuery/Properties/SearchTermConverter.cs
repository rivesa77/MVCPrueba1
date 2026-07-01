// <copyright file="SearchTermConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class SearchTermConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        string>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override string GetPropertyValue(PersonSearchCriteria source)
        {
            return source.SearchTerm;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, string propertyValue)
        {
            result.SearchTerm = propertyValue;
        }
    }
}