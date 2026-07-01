// <copyright file="IdConverterTests.cs" company="Ricardo">
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
    internal class IdConverterTests : PropertyConverterPersonEntityTestBase<
        PersonViewModel,
        IdConverter>
    {
        private static readonly Guid Id = Guid.Parse(PersonConstants.Id);

        /// <inheritdoc/>
        protected override PersonEntity ExpectedValidResult()
        {
            PersonEntity personEntity = new PersonEntity()
            {
                UserId = string.Empty,
                DNI = string.Empty,
                Id = Id,
            };

            return personEntity;
        }

        /// <inheritdoc/>
        protected override PersonViewModel ValidSource()
        {
            PersonViewModel personViewModel = new PersonViewModel()
            {
                Id = Id,
            };

            return personViewModel;
        }
    }
}