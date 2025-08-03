using System;
using System.Collections.Generic;

namespace EcuManagementInterface.Models;

public partial class VehicleModel
{
    public int Id { get; set; }

    public string? ModelName { get; set; }

    public string? SeriesName { get; set; }

    public int? ReleaseYear { get; set; }

    public virtual ICollection<EcuInstance> EcuInstance { get; set; } = new List<EcuInstance>();
}
