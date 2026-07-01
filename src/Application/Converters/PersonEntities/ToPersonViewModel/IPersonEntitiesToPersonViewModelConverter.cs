// <copyright file="IPersonEntitiesToPersonViewModelConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonEntitiesToPersonViewModelConverter : IClassConverter<PersonEntity, PersonViewModel>
    {
    }
}