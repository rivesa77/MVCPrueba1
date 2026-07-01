// <copyright file="IAddPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Creates
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public interface IAddPersonUseCase : IPersonUseCase<PersonViewModel, bool>
    {
    }
}