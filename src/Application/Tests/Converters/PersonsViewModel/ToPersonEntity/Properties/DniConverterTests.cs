// <copyright file="DniConverterTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.Application.Tests.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.MVCPrueba1.Application.Converters.PersonsViewModel.ToPersonEntity.Properties;
    using Ricardo.MVCPrueba1.Application.Models;
    using Ricardo.MVCPrueba1.Application.Tests.Constants;
    using Ricardo.MVCPrueba1.Domain.Entities;

    /// <inheritdoc/>
    [TestClass]
    internal class DniConverterTests : PropertyConverterPersonEntityTestBase<
        PersonViewModel,
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