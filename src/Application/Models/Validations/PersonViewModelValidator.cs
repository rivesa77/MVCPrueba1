// <copyright file="PersonViewModelValidator.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Models.Validations
{
    using System.ComponentModel.DataAnnotations;
    using ROP;

    internal static class PersonViewModelValidator
    {
        private const string DniRequiredMessage = "Person DNI is required";
        private const string DniInvalidMessage = "Person DNI must contain exactly 9 characters";
        private const string NameRequiredMessage = "Person name is required";
        private const string NameInvalidMessage = "Person name can't have more than 100 characters";
        private const string PhoneRequiredMessage = "Person phone is required";
        private const string PhoneInvalidMessage = "Person phone must contain exactly 9 numbers";
        private const string EmailRequiredMessage = "Person email is required";
        private const string EmailInvalidMessage = "Person email is invalid";
        private const string EmailTooLongMessage = "Person email can't have more than 75 characters";

        private static readonly EmailAddressAttribute EmailAddressValidator = new();

        public static Result<bool> Validate(PersonViewModel personViewModel)
        {
            return ValidateDni(personViewModel?.DNI)
                .Bind(_ => ValidateName(personViewModel.Name))
                .Bind(_ => ValidatePhone(personViewModel.Phone))
                .Bind(_ => ValidateEmail(personViewModel.Email));
        }

        private static Result<bool> ValidateDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return Result.Failure<bool>(DniRequiredMessage);
            }

            if (dni.Length != 9)
            {
                return Result.Failure<bool>(DniInvalidMessage);
            }

            return Result.Success(true);
        }

        private static Result<bool> ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Result.Failure<bool>(NameRequiredMessage);
            }

            if (name.Length > 100)
            {
                return Result.Failure<bool>(NameInvalidMessage);
            }

            return Result.Success(true);
        }

        private static Result<bool> ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return Result.Failure<bool>(PhoneRequiredMessage);
            }

            if (phone.Length != 9 || !phone.All(char.IsDigit))
            {
                return Result.Failure<bool>(PhoneInvalidMessage);
            }

            return Result.Success(true);
        }

        private static Result<bool> ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Result.Failure<bool>(EmailRequiredMessage);
            }

            if (email.Length > 75)
            {
                return Result.Failure<bool>(EmailTooLongMessage);
            }

            if (!EmailAddressValidator.IsValid(email))
            {
                return Result.Failure<bool>(EmailInvalidMessage);
            }

            return Result.Success(true);
        }
    }
}