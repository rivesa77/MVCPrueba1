// <copyright file="PhoneConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.Converter.PersonsViewModel.ToPersonEntity.Properties
{
    using MVCPrueba1.Entities;
    using MVCPrueba1.Models;
    using Ricardo.CommonLibraries.Converters;

    internal class PhoneConverter : ClassPropertyConverterBase<
        PersonViewModel,
        PersonEntity,
        string>,
        IPersonsViewModelToPersonEntityPorpertyConverter
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