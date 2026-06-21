// <copyright file="IGetPersonsUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.UseCases.Persons
{
    using MVCPrueba1.Application.Models;

    public interface IGetPersonsUseCase : IGetPersons<IEnumerable<PersonViewModel>>
    {
    }
}