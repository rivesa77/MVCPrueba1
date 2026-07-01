// <copyright file="IPersonsViewModelToPersonEntityPropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonsViewModelToPersonEntityPropertyConverter :
        IClassPropertyConverter<PersonViewModel, PersonEntity>
    {
    }
}