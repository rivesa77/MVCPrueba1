// <copyright file="UserIdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.Converter.PersonsViewModel.ToPersonEntity.Properties
{
    using MVCPrueba1.Entities;
    using MVCPrueba1.Logic.UserInfo;
    using MVCPrueba1.Models;
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