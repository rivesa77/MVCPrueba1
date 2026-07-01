// <copyright file="IGetPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Gets
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface IGetPersonUseCase : IPersonUseCase<Guid, PersonViewModel>
    {
    }
}