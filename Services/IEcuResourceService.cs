using EcuManagementInterface.Models;
using EcuManagementInterface.Models.DTO;

namespace EcuManagementInterface.Services;

public interface IEcuResourceService
{
    Task<List<EcuResourceDto>> GetResourcesByVehicleModelAsync(int vehicleModelId);
}