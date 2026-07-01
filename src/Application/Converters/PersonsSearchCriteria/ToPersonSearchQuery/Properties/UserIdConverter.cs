// <copyright file="UserIdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CleanArchitectureMVC.Application.UserInfo;
    using Ricardo.CommonLibraries.Converters;

    /// <inheritdoc/>
    internal class UserIdConverter : ClassPropertyConverterBase<
        PersonSearchCriteria,
        PersonSearchQuery,
        string>,
        IPersonsSearchCriteriaToPersonSearchQueryPropertyConverter
    {
        private readonly IPersonUserDetails personUserDetails;

        public UserIdConverter(IPersonUserDetails personUserDetails)
        {
            this.personUserDetails = personUserDetails;
        }

        /// <inheritdoc/>
        protected override string GetPropertyValue(PersonSearchCriteria source)
        {
            return this.personUserDetails.UserId;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in PersonSearchQuery result, string propertyValue)
        {
            result.UserId = propertyValue;
        }
    }
}