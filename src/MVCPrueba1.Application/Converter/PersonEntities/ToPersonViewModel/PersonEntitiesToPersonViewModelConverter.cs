// <copyright file="PersonEntitiesToPersonViewModelConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.Converter.PersonEntities.ToPersonViewModel
{
    using MVCPrueba1.Application.Converter.PersonEntities.ToPersonViewModel.Properties;
    using MVCPrueba1.Application.Models;
    using MVCPrueba1.Domain.Entities;
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