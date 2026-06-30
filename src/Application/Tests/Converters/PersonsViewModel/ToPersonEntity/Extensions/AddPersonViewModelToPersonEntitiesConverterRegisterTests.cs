// <copyright file="AddPersonViewModelToPersonEntitiesConverterRegisterTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.Application.Tests.Converters.PersonsViewModel.ToPersonEntity.Extensions
{
    using Ricardo.MVCPrueba1.Application.Converters.PersonsViewModel.ToPersonEntity;
    using Ricardo.MVCPrueba1.Application.Converters.PersonsViewModel.ToPersonEntity.Extensions;
    using Ricardo.MVCPrueba1.Application.Tests.Converters;

    /// <inheritdoc/>
    [TestClass]
    [TestCategory("RegistersConverters")]
    public class AddPersonViewModelToPersonEntitiesConverterRegisterTests :
        RegisterClassAndPropertyConverterTestsBase
    {
        [TestMethod]
        public void AddPersonViewModelToPersonEntitiesConverter_WhenCalled_RegistersConverters()
        {
            AssertRegisterPropertyConverters<IPersonsViewModelToPersonEntityConverter>(
                services => services.AddPersonViewModelToPersonEntitiesConverter());
        }
    }
}