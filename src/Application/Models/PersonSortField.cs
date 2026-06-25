// <copyright file="PersonSortField.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.MVCPrueba1.Application.Models
{
    public enum PersonSortField
    {
        /// <summary>
        ///     Sorts by DNI.
        /// </summary>
        Dni,

        /// <summary>
        ///     Sorts by name.
        /// </summary>
        Name,

        /// <summary>
        ///     Sorts by email.
        /// </summary>
        Email,

        /// <summary>
        ///     Sorts by phone.
        /// </summary>
        Phone,
    }
}
