// <copyright file="PhoneConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class PhoneConverter : ClassPropertyConverterBase<
        PersonEntity,
        PersonViewModel,
        string>,
        IPersonEntitiesToPersonViewModelPropertyConverter
    {
        protected override string GetPropertyValue(PersonEntity source)
        {
            return source.Phone;
        }

        protected override void SetPropertyValue(in PersonViewModel result, string propertyValue)
        {
            result.Phone = propertyValue;
        }
    }
}