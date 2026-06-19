// <copyright file="IAddPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using MVCPrueba1.Models;

    public interface IAddPersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}