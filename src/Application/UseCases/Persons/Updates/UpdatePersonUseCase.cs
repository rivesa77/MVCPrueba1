// <copyright file="UpdatePersonUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Updates
{
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity;
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Models.Extensions;
    using Ricardo.CleanArchitectureMVC.Application.Models.Validations;
    using Ricardo.CleanArchitectureMVC.Application.Repositories;
    using Ricardo.CleanArchitectureMVC.Application.UserInfo;
    using Ricardo.CleanArchitectureMVC.Domain.Entities;
    using ROP;

    internal class UpdatePersonUseCase : IUpdatePersonUseCase
    {
        private const string PersonCantBeUpdateMessage = "Person DNI Already Exist";
        private const string PersonNotFoundMessage = "Person not found";
        private const string PersonNonChangeMessage = "No changes to update";
        private const string PersonDniExistMessage = "Person DNI Already Exist";

        private readonly IPersonRepository personRepository;
        private readonly IPersonsViewModelToPersonEntityConverter converter;
        private readonly IPersonUserDetails personUserDetails;

        public UpdatePersonUseCase(
            IPersonRepository personRepository,
            IPersonsViewModelToPersonEntityConverter converter,
            IPersonUserDetails personUserDetails)
        {
            this.personRepository = personRepository;
            this.converter = converter;
            this.personUserDetails = personUserDetails;
        }

        public async Task<Result<bool>> Execute(PersonViewModel sourceClass)
        {
            if (sourceClass is null || sourceClass.Id == Guid.Empty)
            {
                return Result.Failure<bool>(PersonCantBeUpdateMessage);
            }

            Result<bool> validationResult = PersonViewModelValidator.Validate(sourceClass);

            if (validationResult.Errors.Any())
            {
                return validationResult;
            }

            PersonEntity currentPerson = await this.personRepository
                .GetByIdAndUserIdAsync(sourceClass.Id, this.personUserDetails.UserId)
                .ConfigureAwait(false);

            if (currentPerson is null)
            {
                return Result.Failure<bool>(PersonNotFoundMessage);
            }

            if (!sourceClass.HasChanges(currentPerson))
            {
                return Result.Failure<bool>(PersonNonChangeMessage);
            }

            bool hasDniChanged = !string.Equals(
                sourceClass.DNI,
                currentPerson.DNI,
                StringComparison.Ordinal);

            bool existsDniDb = await this.personRepository
                .ExistsByDniAndIdAsync(sourceClass.DNI, sourceClass.Id)
                .ConfigureAwait(false);

            if (hasDniChanged && existsDniDb)
            {
                return Result.Failure<bool>(PersonDniExistMessage);
            }

            PersonEntity personEntity = this.converter.Convert(sourceClass);

            bool result = await this.personRepository.UpdatePersonAsync(personEntity).ConfigureAwait(false);

            return Result.Success(result);
        }
    }
}