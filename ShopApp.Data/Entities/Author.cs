﻿namespace ShopApp.Data.Entities;

public class Author : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<BookAuthor> BookAuthors { get; set; }
}
