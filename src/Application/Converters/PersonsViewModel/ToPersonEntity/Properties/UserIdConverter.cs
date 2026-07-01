// <copyright file="UserIdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.UserInfo;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class UserIdConverter : ClassPropertyConverterBase<
        PersonViewModel,
        PersonEntity,
        string>,
        IPersonsViewModelToPersonEntityPropertyConverter
    {
        private readonly IPersonUserDetails personUserDetails;

        public UserIdConverter(IPersonUserDetails personUserDetails)
        {
            this.personUserDetails = personUserDetails;
        }

        protected override string GetPropertyValue(PersonViewModel source)
        {
            return this.personUserDetails.UserId;
        }

        protected override void SetPropertyValue(in PersonEntity result, string propertyValue)
        {
            result.UserId = propertyValue;
        }
    }
}