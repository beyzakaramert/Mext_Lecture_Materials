﻿namespace EFPostgre.Domain;

public class Person : EntityBase
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
}
