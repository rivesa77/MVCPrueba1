// <copyright file="AddLogicServiceCollection.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.Extensions
{
    using MVCPrueba1.Logic.UseCases.Extensions;

    public static class AddLogicServiceCollection
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            services.AddUseCases();

            return services;
        }
    }
}