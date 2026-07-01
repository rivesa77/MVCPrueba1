// <copyright file="AddUseCaseServiceCollectionExtensions.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Creates;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Deletes;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Gets;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches;
    using Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Updates;

    public static class AddUseCaseServiceCollectionExtensions
    {
        public static IServiceCollection AddUseCaseServiceCollection(this IServiceCollection services)
        {
            services
                .AddScoped<IAddPersonUseCase, AddPersonUseCase>()
                .AddScoped<IDeletePersonUseCase, DeletePersonUseCase>()
                .AddScoped<IGetPersonUseCase, GetPersonUseCase>()
                .AddScoped<IGetPersonsUseCase, GetPersonsUseCase>()
                .AddScoped<ISearchPersonsUseCase, SearchPersonsUseCase>()
                .AddScoped<IUpdatePersonUseCase, UpdatePersonUseCase>();

            return services;
        }
    }
}