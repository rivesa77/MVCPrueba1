// <copyright file="IPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons
{
    using ROP;

    public interface IPersonUseCase<TSourceClass, TDestinationClass>
    {
        Task<Result<TDestinationClass>> Execute(TSourceClass sourceClass);
    }
}