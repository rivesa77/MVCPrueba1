// <copyright file="IdConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class IdConverter : ClassPropertyConverterBase<
        PersonEntity,
        PersonViewModel,
        Guid>,
        IPersonEntitiesToPersonViewModelPropertyConverter
    {
        protected override Guid GetPropertyValue(PersonEntity source)
        {
            return source.Id;
        }

        protected override void SetPropertyValue(in PersonViewModel result, Guid propertyValue)
        {
            result.Id = propertyValue;
        }
    }
}