// <copyright file="IDeletePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.UseCases.Persons.Deletes
{
    using MVCPrueba1.Application.Models;

    public interface IDeletePersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}