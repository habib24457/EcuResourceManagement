using EcuManagementInterface.Models.DTO;
using EcuManagementInterface.Repositories;

namespace EcuManagementInterface.Services;

public class EcuResourceService(IEcuResourceRepository ecuResourceRepository,
ILogger <EcuResourceService> logger 
):IEcuResourceService
{
    public async Task<List<EcuResourceDto>> GetResourcesByVehicleModelAsync(int vehicleModelId)
    {
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