// <copyright file="AddApplicationExtensions.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace MVCPrueba1.Application.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using MVCPrueba1.Application.Converter.Extensions;
    using MVCPrueba1.Application.UseCases.Extensions;

    public static class AddApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddConverters()
                .AddUseCases();

            return services;
        }
    }
}