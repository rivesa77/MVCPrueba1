// <copyright file="PhoneConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class PhoneConverter : ClassPropertyConverterBase<
        PersonViewModel,
        PersonEntity,
        string>,
        IPersonsViewModelToPersonEntityPropertyConverter
    {
        protected override string GetPropertyValue(PersonViewModel source)
        {
            return source.Phone;
        }

        protected override void SetPropertyValue(in PersonEntity result, string propertyValue)
        {
            result.Phone = propertyValue;
        }
    }
}