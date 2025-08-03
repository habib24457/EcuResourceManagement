namespace EcuManagementInterface.Models.DTO;

public class EcuResourceDto
{
    public string model_name { get; set; }
    public string ecu_type { get; set; }
    public string serial_number { get; set; }
    public string resource_key { get; set; }
    public string resource_value { get; set; }
    public DateTime timestamp { get; set; }
}