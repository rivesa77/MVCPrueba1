// <copyright file="AddPersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Creates
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Models.Validations;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using ROP;

    internal class AddPersonUseCase : IAddPersonUseCase
    {
        private const string DniAlreadyExistMessage = "Person DNI Already Exist";
        private const string ConverterErrorMessage = "Conversion from PersonViewModel to PersonEntity failed, PersonEntity is null";

        private readonly IPersonRepository personRepository;
        private readonly IPersonsViewModelToPersonEntityConverter converter;

        public AddPersonUseCase(
            IPersonRepository personRepository,
            IPersonsViewModelToPersonEntityConverter converter)
        {
            this.personRepository = personRepository;
            this.converter = converter;
        }

        public async Task<Result<bool>> Execute(PersonViewModel personViewModel)
        {
            Result<bool> validationResult = PersonViewModelValidator.Validate(personViewModel);

            if (validationResult.Errors.Any())
            {
                return validationResult;
            }

            return await this.ValidatePerson(personViewModel)
                .Bind(x => this.AddPersonToDatabase(personViewModel))
                .ConfigureAwait(false);
        }

        private async Task<Result<bool>> ValidatePerson(PersonViewModel personViewModel)
        {
            bool personExist = await this.personRepository
                .ExistsByDniAsync(personViewModel.DNI)
                .ConfigureAwait(false);

            if (personExist)
            {
                return Result.Failure<bool>(DniAlreadyExistMessage);
            }

            return true;
        }

        private async Task<Result<bool>> AddPersonToDatabase(PersonViewModel personViewModel)
        {
            PersonEntity personEntity = this.converter.Convert(personViewModel);

            if (personEntity is null)
            {
                return Result.Failure<bool>(ConverterErrorMessage);
            }

            bool result = await this.personRepository.AddAsync(personEntity).ConfigureAwait(false);

            return result;
        }
    }
}