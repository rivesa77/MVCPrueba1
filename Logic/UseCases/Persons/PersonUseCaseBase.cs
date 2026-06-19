// <copyright file="PersonUseCaseBase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using MVCPrueba1.Logic.Repositories;
    using MVCPrueba1.Logic.UserInfo;

    internal class PersonUseCaseBase
    {
        protected IPersonRepository PersonRepository { get; }

        protected IPersonUserDetails PersonUserDetails { get; }

        public PersonUseCaseBase(IPersonRepository personRepository, IPersonUserDetails personUserDetails)
        {
            this.PersonRepository = personRepository;
            this.PersonUserDetails = personUserDetails;
        }
    }
}
