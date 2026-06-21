// <copyright file="IAddPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.UseCases.Persons.Creates
{
    using MVCPrueba1.Application.Models;

    public interface IAddPersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}