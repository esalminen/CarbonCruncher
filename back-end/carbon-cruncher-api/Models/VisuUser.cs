﻿using System;
using System.Collections.Generic;

namespace carbon_cruncher_api.Models;

public partial class VisuUser
{
    public int Id { get; set; }

    public string UserNick { get; set; } = null!;

    public string UserPass { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public virtual ICollection<VisuUserVisual> VisuUserVisuals { get; } = new List<VisuUserVisual>();
}
