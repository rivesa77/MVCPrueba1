// <copyright file="DniConverterTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.Application.Tests.Converter.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity.Properties;
    using Ricardo.MVCPrueba1.Application.Models;
    using Ricardo.MVCPrueba1.Application.Tests.Constants;
    using Ricardo.MVCPrueba1.Domain.Entities;

    /// <inheritdoc/>
    [TestClass]
    internal class DniConverterTests : PropertyConverterTestBase<
        PersonViewModel,
        PersonEntity,
        DniConverter>
    {
        /// <inheritdoc/>
        protected override PersonEntity ExpectedValidResult()
        {
            PersonEntity personEntity = new PersonEntity()
            {
                UserId = string.Empty,
                DNI = PersonConstants.Dni,
            };

            return personEntity;
        }

        /// <inheritdoc/>
        protected override PersonEntity ValidResult()
        {
            PersonEntity personEntity = new PersonEntity()
            {
                UserId = string.Empty,
                DNI = string.Empty,
            };

            return personEntity;
        }

        /// <inheritdoc/>
        protected override PersonViewModel ValidSource()
        {
            PersonViewModel personViewModel = new PersonViewModel()
            {
                DNI = PersonConstants.Dni,
            };

            return personViewModel;
        }
    }
}