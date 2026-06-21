// <copyright file="UserIdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity.Properties
{
    using MVCPrueba1.Application.Models;
    using MVCPrueba1.Application.UserInfo;
    using MVCPrueba1.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class UserIdConverter : ClassPropertyConverterBase<
        PersonViewModel,
        PersonEntity,
        string>,
        IPersonsViewModelToPersonEntityPorpertyConverter
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