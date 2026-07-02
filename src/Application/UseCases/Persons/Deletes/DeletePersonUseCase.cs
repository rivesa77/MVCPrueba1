// <copyright file="DeletePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Deletes
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using ROP;

    internal class DeletePersonUseCase : IDeletePersonUseCase
    {
        private const string PersonRequiredMessage = "Person is required";

        private readonly IPersonRepository personRepository;
        private readonly IPersonsViewModelToPersonEntityConverter converter;

        public DeletePersonUseCase(IPersonRepository personRepository, IPersonsViewModelToPersonEntityConverter converter)
        {
            this.personRepository = personRepository;
            this.converter = converter;
        }

        public async Task<Result<bool>> Execute(PersonViewModel sourceClass)
        {
            if (sourceClass is null)
            {
                return Result.Failure<bool>(PersonRequiredMessage);
            }

            PersonEntity personEntity = this.converter.Convert(sourceClass);

            return await this.personRepository.DeletePersonAsync(personEntity);
        }
    }
}