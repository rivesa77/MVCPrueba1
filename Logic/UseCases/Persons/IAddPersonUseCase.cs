// <copyright file="IAddPersonUseCase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using ROP;

    public interface IAddPersonUseCase
    {
        Task<Result<bool>> Execute(string dni);
    }
}