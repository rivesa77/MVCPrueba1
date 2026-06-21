// <copyright file="IPersonEntitiesToPersonViewModelConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.Converter.PersonEntities.ToPersonViewModel
{
    using MVCPrueba1.Application.Models;
    using MVCPrueba1.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonEntitiesToPersonViewModelConverter : IClassConverter<PersonEntity, PersonViewModel>
    {
    }
}