// <copyright file="PropertyConverterPersonEntityTestBase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Tests.Converters
{
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using Ricardo.CommonLibraries.Converters;

    [TestCategory("PropertyConverterPersonEntity")]
    internal abstract class PropertyConverterPersonEntityTestBase<TSourceClass, TPropertyConverter> : PropertyConverterWithRequiredFieldTestBase<
        TSourceClass,
        PersonEntity,
        TPropertyConverter>
        where TSourceClass : class, new()
        where TPropertyConverter : class, IClassPropertyConverter<TSourceClass, PersonEntity>, new()
    {
        private static readonly PersonEntity EmptyPersonEntity = new PersonEntity()
        {
            UserId = string.Empty,
            DNI = string.Empty,
        };

        /// <inheritdoc/>
        protected override PersonEntity ValidResult()
        {
            return EmptyPersonEntity;
        }
    }
}