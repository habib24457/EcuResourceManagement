using System;
using System.Collections.Generic;

namespace EcuManagementInterface.Models;

public partial class EcuInstance
{
    public int Id { get; set; }

    public int? VehicleModelId { get; set; }

    public int? EcuTypeId { get; set; }

    public string? SerialNumber { get; set; }

    public string? FirmwareVersion { get; set; }

    public DateOnly? InstallationDate { get; set; }

    public virtual ICollection<EcuResourceData> EcuResourceData { get; set; } = new List<EcuResourceData>();

    public virtual EcuType? EcuType { get; set; }

    public virtual VehicleModel? VehicleModel { get; set; }
}
