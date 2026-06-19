// <copyright file="IPersonsViewModelToPersonEntityPorpertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.Converter.PersonsViewModel.ToPersonEntity.Properties
{
    using MVCPrueba1.Entities;
    using MVCPrueba1.Models;
    using Ricardo.CommonLibraries.Converters;

    internal interface IPersonsViewModelToPersonEntityPorpertyConverter :
        IClassPropertyConverter<PersonViewModel, PersonEntity>
    {
    }
}