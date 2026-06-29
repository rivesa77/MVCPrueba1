// <copyright file="AddPersonViewModelToPersonEntitiesPropertyConverterRegisterTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.Application.Tests.Converter.PersonsViewModel.ToPersonEntity.Extensions
{
    using Ricardo.MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity.Extensions;
    using Ricardo.MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity.Properties;

    /// <inheritdoc/>
    [TestClass]
    [TestCategory("RegistersAllPropertyConverters")]
    public class AddPersonViewModelToPersonEntitiesPropertyConverterRegisterTests :
        RegisterClassAndPropertyConverterTestsBase
    {
        [TestMethod]
        public void AddPersonViewModelToPersonEntitiesConverter_WhenCalled_RegistersAllPropertyConverters()
        {
            AssertRegisterPropertyConverters<IPersonsViewModelToPersonEntityPropertyConverter>(
                services => services.AddPersonViewModelToPersonEntitiesConverter());
        }
    }
}