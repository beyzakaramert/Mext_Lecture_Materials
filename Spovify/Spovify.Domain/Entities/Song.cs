﻿namespace Spovify.Domain;

public class Song : EntityBase<Guid>
{
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public Producer Producer { get; set; }
}
