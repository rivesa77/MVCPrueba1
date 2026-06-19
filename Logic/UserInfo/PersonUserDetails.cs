// <copyright file="PersonUserDetails.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UserInfo
{
    using System.Security.Claims;

    public class PersonUserDetails : IPersonUserDetails
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public PersonUserDetails(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string UserId => this.httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value
            ?? throw new Exception("This workflow require authentication");
    }
}