// <copyright file="PhoneConverterTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Tests.Converters.PersonsViewModel.ToPersonEntity.Properties
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Tests.Constants;
    using Ricardo.CleanArchitectureMVC.Application.Tests.Converters;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;

    /// <inheritdoc/>
    [TestClass]
    internal class PhoneConverterTests : PropertyConverterPersonEntityTestBase<
        PersonViewModel,
        PhoneConverter>
    {
        /// <inheritdoc/>
        protected override PersonEntity ExpectedValidResult()
        {
            PersonEntity personEntity = new PersonEntity()
            {
                UserId = string.Empty,
                DNI = string.Empty,
                Phone = PersonConstants.Phone,
            };

            return personEntity;
        }

        /// <inheritdoc/>
        protected override PersonViewModel ValidSource()
        {
            PersonViewModel personViewModel = new PersonViewModel()
            {
                Phone = PersonConstants.Phone,
            };

            return personViewModel;
        }
    }
}