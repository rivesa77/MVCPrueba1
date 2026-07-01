// <copyright file="PersonsViewModelToPersonEntityConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal class PersonsViewModelToPersonEntityConverter : ClassConverterNonInitializeBase<
        PersonViewModel,
        PersonEntity,
        IPersonsViewModelToPersonEntityPropertyConverter>,
        IPersonsViewModelToPersonEntityConverter
    {
        public PersonsViewModelToPersonEntityConverter(
            IEnumerable<IPersonsViewModelToPersonEntityPropertyConverter> propertyConverters)
            : base(propertyConverters)
        {
        }

        protected override PersonEntity InitializeDestination()
        {
            return new PersonEntity()
            {
                DNI = string.Empty,
                UserId = string.Empty,
            };
        }
    }
}