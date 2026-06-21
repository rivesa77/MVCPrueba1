// <copyright file="IPersonsViewModelToPersonEntityConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity
{
    using MVCPrueba1.Application.Models;
    using MVCPrueba1.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonsViewModelToPersonEntityConverter : IClassConverter<PersonViewModel, PersonEntity>
    {
    }
}