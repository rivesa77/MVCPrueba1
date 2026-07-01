// <copyright file="AddPersonViewModelToPersonEntitiesConverterExtension.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Properties;

    internal static class AddPersonViewModelToPersonEntitiesConverterExtension
    {
        internal static IServiceCollection AddPersonViewModelToPersonEntitiesConverter(this IServiceCollection services)
        {
            services
                .AddScoped<
                    IPersonsViewModelToPersonEntityConverter,
                    PersonsViewModelToPersonEntityConverter>();

            services
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, DniConverter>()
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, EmailConverter>()
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, IdConverter>()
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, NameConverter>()
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, PhoneConverter>()
                .AddScoped<IPersonsViewModelToPersonEntityPropertyConverter, UserIdConverter>();

            return services;
        }
    }
}