// <copyright file="IPersonRepository.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.Repositories
{
    using MVCPrueba1.Entities;

    // <remark>la interfaz vive donde se consume; la implementación vive donde se ejecuta el detalle técnico.Si se cambia la implementación, no se cambia la interfaz. La interfaz es un contrato que define lo que se espera de la implementación.</remark>
    internal interface IPersonRepository
    {
        Task<bool> ExistsByDniAsync(string dni);

        Task AddAsync(PersonEntity personEntity);

        Task<IEnumerable<PersonEntity>> GetByUserIdAsync(string userId);

        Task<PersonEntity> GetByIdAndUserIdAsync(Guid id, string userId);
    }
}