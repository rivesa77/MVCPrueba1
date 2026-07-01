// <copyright file="IdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using System;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class IdConverter : ClassPropertyConverterBase<
        PersonViewModel,
        PersonEntity,
        Guid>,
        IPersonsViewModelToPersonEntityPropertyConverter
    {
        protected override Guid GetPropertyValue(PersonViewModel source)
        {
            return source.Id;
        }

        protected override void SetPropertyValue(in PersonEntity result, Guid propertyValue)
        {
            result.Id = propertyValue;
        }
    }
}