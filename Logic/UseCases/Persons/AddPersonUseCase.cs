// <copyright file="AddPersonUseCase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using Microsoft.EntityFrameworkCore;
    using MVCPrueba1.Data;
    using MVCPrueba1.Entities;
    using ROP;

    public class AddPersonUseCase : IAddPersonUseCase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AddPersonUseCase(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<Result<bool>> Execute(string dni)
        {
            return await this.ValidatePerson(dni).Bind(x => this.AddPersonToDatabase(x)).ConfigureAwait(false);
        }

        private async Task<Result<string>> ValidatePerson(string dni)
        {
            bool flagExist = await this.applicationDbContext.Persons
                .Where(p => p.DNI.ToLower() == dni.ToLower())
                .AnyAsync()
                .ConfigureAwait(false);

            if (flagExist)
            {
                return Result.Failure<string>("Person DNI Already Exist");
            }

            return dni;
        }

        private async Task<Result<bool>> AddPersonToDatabase(string dni)
        {
            PersonEntity personEntity = new PersonEntity()
            {
                DNI = dni,
                UserId = flagUserDetails.UserId,
            };

            await this.applicationDbContext.AddAsync(personEntity);
            await this.applicationDbContext.SaveChangesAsync();

            return true;
        }
    }
}