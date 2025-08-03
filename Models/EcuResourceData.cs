using System;
using System.Collections.Generic;

namespace EcuManagementInterface.Models;

public partial class EcuResourceData
{
    public int Id { get; set; }

    public int? EcuInstanceId { get; set; }

    public string? ResourceKey { get; set; }

    public string? ResourceValue { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual EcuInstance? EcuInstance { get; set; }
}
