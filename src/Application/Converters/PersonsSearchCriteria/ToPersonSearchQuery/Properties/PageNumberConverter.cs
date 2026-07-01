// <copyright file="PageNumberConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class PageNumberConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        int>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override int GetPropertyValue(PersonSearchCriteria source)
        {
            return source.PageNumber;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, int propertyValue)
        {
            result.PageNumber = propertyValue;
        }
    }
}