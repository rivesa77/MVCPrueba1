// <copyright file="IUpdatePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Updates
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface IUpdatePersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}