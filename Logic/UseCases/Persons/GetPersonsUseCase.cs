// <copyright file="GetPersonsUseCase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using MVCPrueba1.Entities;
    using MVCPrueba1.Logic.Converter.PersonEntities.ToPersonViewModel;
    using MVCPrueba1.Logic.Repositories;
    using MVCPrueba1.Logic.UserInfo;
    using MVCPrueba1.Models;
    using ROP;

    internal class GetPersonsUseCase : PersonUseCaseBase, IGetPersonsUseCase
    {
        private readonly IPersonEntitiesToPersonViewModelConverter converter;

        public GetPersonsUseCase(
            IPersonRepository personRepository,
            IPersonUserDetails personUserDetails,
            IPersonEntitiesToPersonViewModelConverter converter)
            : base(personRepository, personUserDetails)
        {
            this.converter = converter;
        }

        public async Task<Result<IEnumerable<PersonViewModel>>> Execute()
        {
            return await this.GetPersonsFromDatabase();
        }

        private async Task<Result<IEnumerable<PersonViewModel>>> GetPersonsFromDatabase()
        {
            string userId = this.PersonUserDetails.UserId;

            IEnumerable<PersonEntity> personEntities = await this.PersonRepository
                .GetByUserIdAsync(userId)
                .ConfigureAwait(false);

            IEnumerable<PersonViewModel> persons = personEntities.Select(p => this.converter.Convert(p));

            return Result.Success(persons);
        }
    }
}