// <copyright file="IPersonsViewModelToPersonEntityConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonsViewModelToPersonEntityConverter : IClassConverter<PersonViewModel, PersonEntity>
    {
    }
}