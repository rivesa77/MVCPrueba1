// <copyright file="AddUseCaseServiceCollection.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Logic.UseCases.Extensions
{
    using MVCPrueba1.Data.Repositories;
    using MVCPrueba1.Logic.Repositories;
    using MVCPrueba1.Logic.UseCases.Persons;
    using MVCPrueba1.Logic.UserInfo;

    public static class AddUseCaseServiceCollection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services
                .AddScoped<IAddPersonUseCase, AddPersonUseCase>()
                .AddScoped<IGetPersonsUseCase, GetPersonsUseCase>()
                .AddScoped<IGetPersonUseCase, GetPersonUseCase>()
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IPersonUserDetails, PersonUserDetails>();

            return services;
        }
    }
}