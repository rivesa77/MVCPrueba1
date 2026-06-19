// <copyright file="PersonRepository.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using MVCPrueba1.Entities;
    using MVCPrueba1.Logic.Repositories;

    internal class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PersonRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<bool> ExistsByDniAsync(string dni)
        {
            return await this.applicationDbContext.Persons
                .AnyAsync(p => p.DNI.ToLower() == dni.ToLower())
                .ConfigureAwait(false);
        }

        public async Task AddAsync(PersonEntity personEntity)
        {
            await this.applicationDbContext.AddAsync(personEntity).ConfigureAwait(false);
            await this.applicationDbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<PersonEntity>> GetByUserIdAsync(string userId)
        {
            return await this.applicationDbContext.Persons
                .Where(p => p.UserId == userId)
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<PersonEntity> GetByIdAndUserIdAsync(Guid id, string userId)
        {
            return await this.applicationDbContext.Persons
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id && p.UserId == userId)
                .ConfigureAwait(false);
        }
    }
}