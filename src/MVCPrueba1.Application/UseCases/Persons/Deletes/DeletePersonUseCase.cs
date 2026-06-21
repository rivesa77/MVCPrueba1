// <copyright file="DeletePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.UseCases.Persons.Deletes
{
    using MVCPrueba1.Application.Converter.PersonsViewModel.ToPersonEntity;
    using MVCPrueba1.Application.Models;
    using MVCPrueba1.Application.Repositories;
    using MVCPrueba1.Domain.Entities;
    using ROP;

    internal class DeletePersonUseCase : IDeletePersonUseCase
    {
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
                return Result.Failure<bool>("sourceClass is required");
            }

            PersonEntity personEntity = this.converter.Convert(sourceClass);

            return await this.personRepository.DeletePersonAsync(personEntity);
        }
    }
}