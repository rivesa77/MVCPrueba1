// <copyright file="PersonUser.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UserInfo
{
    using System.Security.Claims;

    public class PersonUser : IPersonUserDetails
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public PersonUser(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string UserId => this.httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value
            ?? throw new Exception("This workflow require authentication");
    }
}