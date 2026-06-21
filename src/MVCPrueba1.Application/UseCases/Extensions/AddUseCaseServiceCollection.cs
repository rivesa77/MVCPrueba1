// <copyright file="AddUseCaseServiceCollection.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.UseCases.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using MVCPrueba1.Application.UseCases.Persons.Creates;
    using MVCPrueba1.Application.UseCases.Persons.Deletes;
    using MVCPrueba1.Application.UseCases.Persons.Gets;
    using MVCPrueba1.Application.UseCases.Persons.Updates;

    public static class AddUseCaseServiceCollection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services
                .AddScoped<IAddPersonUseCase, AddPersonUseCase>()
                .AddScoped<IDeletePersonUseCase, DeletePersonUseCase>()
                .AddScoped<IGetPersonUseCase, GetPersonUseCase>()
                .AddScoped<IGetPersonsUseCase, GetPersonsUseCase>()
                .AddScoped<IUpdatePersonUseCase, UpdatePersonUseCase>();

            return services;
        }
    }
}