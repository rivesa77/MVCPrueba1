// <copyright file="PersonViewModelValidatorTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Tests.Models.Validations
{
    using FluentAssertions;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Models.Validations;
    using Ricardo.CleanArchitectureMVC.Application.Tests.Constants;
    using ROP;

    [TestClass]
    [TestCategory("PersonViewModelValidator")]
    public class PersonViewModelValidatorTests
    {
        [TestMethod]
        public void Validate_WhenPersonIsValid_ReturnsSuccess()
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            result.Value
                .Should()
                .BeTrue();

            result.Errors
                .Should()
                .BeEmpty();
        }

        [TestMethod]
        public void Validate_WhenPersonViewModelIsNull_ReturnsExpectedError()
        {
            // Arrange.
            PersonViewModel personViewModel = null;

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, ValidatorConstantTests.DniRequiredMessage);
        }

        [TestMethod]
        [DataRow(null, ValidatorConstantTests.DniRequiredMessage)]
        [DataRow(" ", ValidatorConstantTests.DniRequiredMessage)]
        [DataRow("12345678", ValidatorConstantTests.DniInvalidMessage)]
        [DataRow("1234567890", ValidatorConstantTests.DniInvalidMessage)]
        public void Validate_WhenDniIsInvalid_ReturnsExpectedError(string dni, string expectedMessage)
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.DNI = dni;

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, expectedMessage);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void Validate_WhenNameIsMissing_ReturnsExpectedError(string name)
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.Name = name;

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, ValidatorConstantTests.NameRequiredMessage);
        }

        [TestMethod]
        public void Validate_WhenNameIsTooLong_ReturnsExpectedError()
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.Name = new string('a', 101);

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, ValidatorConstantTests.NameInvalidMessage);
        }

        [TestMethod]
        [DataRow(null, ValidatorConstantTests.PhoneRequiredMessage)]
        [DataRow(" ", ValidatorConstantTests.PhoneRequiredMessage)]
        [DataRow("12345678", ValidatorConstantTests.PhoneInvalidMessage)]
        [DataRow("1234567890", ValidatorConstantTests.PhoneInvalidMessage)]
        [DataRow("12345678A", ValidatorConstantTests.PhoneInvalidMessage)]
        public void Validate_WhenPhoneIsInvalid_ReturnsExpectedError(string phone, string expectedMessage)
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.Phone = phone;

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, expectedMessage);
        }

        [TestMethod]
        [DataRow(null, ValidatorConstantTests.EmailRequiredMessage)]
        [DataRow(" ", ValidatorConstantTests.EmailRequiredMessage)]
        [DataRow("invalid-email", ValidatorConstantTests.EmailInvalidMessage)]
        public void Validate_WhenEmailIsInvalid_ReturnsExpectedError(string email, string expectedMessage)
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.Email = email;

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, expectedMessage);
        }

        [TestMethod]
        public void Validate_WhenEmailIsTooLong_ReturnsExpectedError()
        {
            // Arrange.
            PersonViewModel personViewModel = CreateValidPerson();
            personViewModel.Email = $"{new string('a', 64)}@example.com";

            // Act.
            Result<bool> result = PersonViewModelValidator.Validate(personViewModel);

            // Assert.
            ValidateFailure(result, ValidatorConstantTests.EmailTooLongMessage);
        }

        private static PersonViewModel CreateValidPerson()
        {
            return new PersonViewModel()
            {
                DNI = PersonConstants.Dni,
                Name = PersonConstants.Name,
                Phone = PersonConstants.Phone,
                Email = PersonConstants.Email,
            };
        }

        private static void ValidateFailure(Result<bool> result, string expectedMessage)
        {
            result.Value
                .Should()
                .BeFalse();

            result.Errors
                .Should()
                .ContainSingle();

            result.Errors.First().Message
                .Should()
                .Be(expectedMessage);
        }
    }
}