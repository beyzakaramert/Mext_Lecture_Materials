﻿using TwoTaxiApp.Domain.Common;

namespace TwoTaxiApp.Domain;

public class Person : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
}
