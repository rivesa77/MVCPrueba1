// <copyright file="PageSizeConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class PageSizeConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        int>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        /// <inheritdoc/>
        protected override int GetPropertyValue(PersonSearchCriteria source)
        {
            return source.PageSize;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, int propertyValue)
        {
            result.PageSize = propertyValue;
        }
    }
}