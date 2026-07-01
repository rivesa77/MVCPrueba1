// <copyright file="IDeletePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Deletes
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface IDeletePersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}