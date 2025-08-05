using System.Data;
using Dapper;
using EcuManagementInterface.Models.DTO;
using Microsoft.Data.SqlClient;

namespace EcuManagementInterface.Repositories;

public class EcuResourceRepository(IDbConnection dbConnection):IEcuResourceRepository
{
    public async Task<List<EcuResourceDto>> GetAllResourcesByVehicleIdAsync(int vehicleModelId)
    {
        var parameters = new { vehicleModelId };
        var results = await dbConnection.QueryAsync<EcuResourceDto>(
            "usp_GetEcuResourcesByVehicleModel", 
            parameters, 
            commandType: CommandType.StoredProcedure);
        
        return results.ToList();
    }
}