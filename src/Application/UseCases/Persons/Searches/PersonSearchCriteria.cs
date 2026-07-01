// <copyright file="PersonSearchCriteria.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CleanArchitectureMVC.Application.UseCases.Persons.Searches
{
    using Ricardo.CleanArchitectureMVC.Application.Models;

    public class PersonSearchCriteria
    {
        public PersonSearchField SearchField { get; set; } = PersonSearchField.All;

        public string SearchTerm { get; set; }

        public PersonSortField SortField { get; set; } = PersonSortField.Name;

        public PersonSortDirection SortDirection { get; set; } = PersonSortDirection.Ascending;

        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 5;
    }
}
