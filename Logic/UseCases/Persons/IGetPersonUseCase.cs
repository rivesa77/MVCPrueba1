// <copyright file="IGetPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using MVCPrueba1.Models;

    public interface IGetPersonUseCase : IPersonUseCase<Guid, PersonViewModel>
    {
    }
}