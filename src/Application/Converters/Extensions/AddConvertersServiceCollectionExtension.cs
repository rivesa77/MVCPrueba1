// <copyright file="AddConvertersServiceCollectionExtension.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Converters.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonEntities.ToPersonViewModel.Extensions;
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsSearchCriteria.ToPersonSearchQuery.Extensions;
    using Ricardo.CleanArchitectureMVC.Application.Converters.PersonsViewModel.ToPersonEntity.Extensions;

    internal static class AddConvertersServiceCollectionExtension
    {
        internal static IServiceCollection AddConvertersServiceCollection(this IServiceCollection services)
        {
            services
                .AddPersonEntitiesToPersonViewModelConverter()
                .AddPersonsSearchCriteriaToPersonSearchQueryConverter()
                .AddPersonViewModelToPersonEntitiesConverter();

            return services;
        }
    }
}