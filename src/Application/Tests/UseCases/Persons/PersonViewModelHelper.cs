// <copyright file="PersonViewModelHelper.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.Tests.UseCases.Persons
{
    using Ricardo.CleanArchitectureMVC.Application.Models;
    using Ricardo.CleanArchitectureMVC.Application.Tests.Constants;

    internal static class PersonViewModelHelper
    {
        public static PersonViewModel SetValueInProperty(PersonViewModelField propertyName, string value)
        {
            PersonViewModel personViewModel = new PersonViewModel()
            {
                Id = Guid.Parse(PersonConstants.Id),
                DNI = PersonConstants.Dni,
                Name = PersonConstants.Name,
                Phone = PersonConstants.Phone,
                Email = PersonConstants.Email,
            };

            switch (propertyName)
            {
                case PersonViewModelField.Dni:
                    personViewModel.DNI = value;
                    break;

                case PersonViewModelField.Name:
                    personViewModel.Name = value;
                    break;

                case PersonViewModelField.Phone:
                    personViewModel.Phone = value;
                    break;

                case PersonViewModelField.Email:
                    personViewModel.Email = value;
                    break;
            }

            return personViewModel;
        }
    }
}