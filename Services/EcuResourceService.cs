using EcuManagementInterface.Models.DTO;
using EcuManagementInterface.Repositories;

namespace EcuManagementInterface.Services;

public class EcuResourceService(IEcuResourceRepository ecuResourceRepository,
ILogger <EcuResourceService> logger 
):IEcuResourceService
{
    public async Task<List<EcuResourceDto>> GetResourcesByVehicleModelAsync(int vehicleModelId)
    {
        if (vehicleModelId <= 0)
        {
            logger.LogError("Invalid Vehicle Model ID");
            return new List<EcuResourceDto>();
        }
        
        try
        {
            var resources = await ecuResourceRepository.GetAllResourcesByVehicleIdAsync(vehicleModelId);
            logger.LogInformation($"Successfully Loaded the ECU resources for Vehicle Model {vehicleModelId}");
            return resources;
        }
        catch(Exception exception)
        {
            logger.LogError($"Could not fetch the ECU Resources for Vehicle Model: {vehicleModelId} due to exception: ",exception );
            return new List<EcuResourceDto>(); 
        }
    }
}