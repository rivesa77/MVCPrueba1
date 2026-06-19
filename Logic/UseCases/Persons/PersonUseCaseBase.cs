// <copyright file="PersonUseCaseBase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Persons
{
    using MVCPrueba1.Data;
    using MVCPrueba1.Logic.UserInfo;

    public class PersonUseCaseBase
    {
        protected ApplicationDbContext ApplicationDbContext { get; }

        protected IPersonUserDetails PersonUserDetails { get; }

        public PersonUseCaseBase(ApplicationDbContext applicationDbContext, IPersonUserDetails personUserDetails)
        {
            this.ApplicationDbContext = applicationDbContext;
            this.PersonUserDetails = personUserDetails;
        }
    }
}