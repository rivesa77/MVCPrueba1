// <copyright file="IGetPersonsUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Gets
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface IGetPersonsUseCase : IGetPersons<IEnumerable<PersonViewModel>>
    {
    }
}