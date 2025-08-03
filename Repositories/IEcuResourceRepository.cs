using EcuManagementInterface.Models.DTO;

namespace EcuManagementInterface.Repositories;

public interface IEcuResourceRepository
{
    public Task<List<EcuResourceDto>> GetAllResourcesByVehicleIdAsync(int vehicleModelId);
}