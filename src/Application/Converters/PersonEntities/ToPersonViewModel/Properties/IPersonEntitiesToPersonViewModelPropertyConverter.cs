// <copyright file="IPersonEntitiesToPersonViewModelPropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonEntitiesToPersonViewModelPropertyConverter :
        IClassPropertyConverter<PersonEntity, PersonViewModel>
    {
    }
}