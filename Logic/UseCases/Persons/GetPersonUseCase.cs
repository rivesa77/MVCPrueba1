// <copyright file="GetPersonUseCase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using Microsoft.EntityFrameworkCore;
    using MVCPrueba1.Data;
    using MVCPrueba1.Entities;
    using MVCPrueba1.Logic.Converter.PersonEntities.ToPersonViewModel;
    using MVCPrueba1.Logic.UserInfo;
    using MVCPrueba1.Models;
    using ROP;

    internal class GetPersonUseCase : PersonUseCaseBase, IGetPersonUseCase
    {
        private readonly IPersonEntitiesToPersonViewModelConverter converter;

        public GetPersonUseCase(
            ApplicationDbContext applicationDbContext,
            IPersonUserDetails personUserDetails,
            IPersonEntitiesToPersonViewModelConverter converter)
            : base(applicationDbContext, personUserDetails)
        {
            this.converter = converter;
        }

        public async Task<Result<PersonViewModel>> Execute(Guid sourceClass)
        {
            if (sourceClass == Guid.Empty)
            {
                return Result.Failure<PersonViewModel>("No data");
            }

            return await this.GetPerson(sourceClass).ConfigureAwait(false);
        }

        private async Task<Result<PersonViewModel>> GetPerson(Guid id)
        {
            PersonEntity person = await this.ApplicationDbContext
                .Persons
                .SingleOrDefaultAsync(p => p.Id == id)
                .ConfigureAwait(false);

            if (person is null)
            {
                return Result.Failure<PersonViewModel>("Person not found");
            }

            return this.converter.Convert(person);
        }
    }
}