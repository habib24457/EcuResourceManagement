namespace EcuManagementInterface.Models.DTO;

public class EcuResourceDto
{
    public string ModelName { get; set; }
    public string EcuType { get; set; }
    public string SerialNumber { get; set; }
    public string ResourceKey { get; set; }
    public string ResourceValue { get; set; }
    public DateTime TimeStampDate { get; set; }
}