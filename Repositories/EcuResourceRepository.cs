using System.Data;
using Dapper;
using EcuManagementInterface.Models.DTO;
using Microsoft.Data.SqlClient;

namespace EcuManagementInterface.Repositories;

public class EcuResourceRepository(IConfiguration configuration):IEcuResourceRepository
{
    public async Task<List<EcuResourceDto>> GetAllResourcesByVehicleIdAsync(int vehicleModelId)
    {
        using var connection = new SqlConnection(configuration.GetConnectionString("EcuDb"));
        var parameters = new { vehicleModelId };
        var results = await connection.QueryAsync<EcuResourceDto>(
            "usp_GetEcuResourcesByVehicleModel", 
            parameters, 
            commandType: CommandType.StoredProcedure);
        
        return results.ToList();
    }
}