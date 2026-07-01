// <copyright file="PersonEntitiesToPersonViewModelConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel.Properties;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class PersonEntitiesToPersonViewModelConverter : ClassConverterBase<
        PersonEntity,
        PersonViewModel,
        IPersonEntitiesToPersonViewModelPropertyConverter>,
        IPersonEntitiesToPersonViewModelConverter
    {
        public PersonEntitiesToPersonViewModelConverter(
            IEnumerable<IPersonEntitiesToPersonViewModelPropertyConverter> propertyConverters)
            : base(propertyConverters)
        {
        }
    }
}