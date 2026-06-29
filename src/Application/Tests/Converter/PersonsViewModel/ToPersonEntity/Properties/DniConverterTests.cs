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
    internal class DniConverterTests : PropertyConverterWithRequiredFieldTestBase<
        PersonViewModel,
        PersonEntity,
        DniConverter>
    {
        private static readonly PersonEntity EmptyPersonEntity = new PersonEntity()
        {
            UserId = string.Empty,
            DNI = string.Empty,
        };

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
            return EmptyPersonEntity;
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

        /// <inheritdoc/>
        protected override PersonEntity EmptyDestinationClass()
        {
            return EmptyPersonEntity;
        }

        /// <inheritdoc/>
        protected override PersonViewModel EmptySourceClass()
        {
            return new PersonViewModel();
        }

        protected override PersonEntity ExpectedEmptyDestinationClass()
        {
            return EmptyPersonEntity;
        }
    }
}