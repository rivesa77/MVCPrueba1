// <copyright file="PersonsSearchCriteriaToPersonSearchQueryConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery
{
    using System.Collections.Generic;
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class PersonsSearchCriteriaToPersonSearchQueryConverter : ClassConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter>,
        IPersonsSearchCriteriaToPersonSearchQueryConverter
    {
        public PersonsSearchCriteriaToPersonSearchQueryConverter(
            IEnumerable<IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter> propertyConverters)
            : base(propertyConverters)
        {
        }
    }
}