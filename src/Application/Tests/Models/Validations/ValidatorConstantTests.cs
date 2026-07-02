// <copyright file="ValidatorConstantTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Tests.Models.Validations
{
    internal static class ValidatorConstantTests
    {
        /// <summary>
        ///     Constant message for DNI required validation.
        /// </summary>
        public const string DniRequiredMessage = "Person DNI is required";

        /// <summary>
        ///     Constant message for DNI Invalid validation.
        /// </summary>
        public const string DniInvalidMessage = "Person DNI must contain exactly 9 characters";

        /// <summary>
        ///     Constant message for Name required validation.
        /// </summary>
        public const string NameRequiredMessage = "Person name is required";

        /// <summary>
        ///     Constant message for Name Invalid validation.
        /// </summary>
        public const string NameInvalidMessage = "Person name can't have more than 100 characters";

        /// <summary>
        ///     Constant message for Phone required validation.
        /// </summary>
        public const string PhoneRequiredMessage = "Person phone is required";

        /// <summary>
        ///     Constant message for Phone Invalid validation.
        /// </summary>
        public const string PhoneInvalidMessage = "Person phone must contain exactly 9 numbers";

        /// <summary>
        ///     Constant message for Email required validation.
        /// </summary>
        public const string EmailRequiredMessage = "Person email is required";

        /// <summary>
        ///     Constant message for Email Invalid validation.
        /// </summary>
        public const string EmailInvalidMessage = "Person email is invalid";

        /// <summary>
        ///     Constant message for Email Invalid long.
        /// </summary>
        public const string EmailTooLongMessage = "Person email can't have more than 75 characters";
    }
}