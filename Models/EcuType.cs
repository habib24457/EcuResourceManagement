using System;
using System.Collections.Generic;

namespace EcuManagementInterface.Models;

public partial class EcuType
{
    public int Id { get; set; }

    public string? TypeName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EcuInstance> EcuInstance { get; set; } = new List<EcuInstance>();
}
