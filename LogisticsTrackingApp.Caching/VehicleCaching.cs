using LogisticsTrackingApp.Core.Dtos.VehicleDtos;
using LogisticsTrackingApp.Core.Models;
using LogisticsTrackingApp.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Caching
{
	internal class VehicleCaching : IVehicleService
	{
		public void Add(Vehicle entity)
		{
			throw new NotImplementedException();
		}

		public Task AddVehicleAsync(CreateVehicleDto createVehicle)
		{
			throw new NotImplementedException();
		}

		public Task<Vehicle> DeleteAsync(Vehicle Entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteVehicleAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Vehicle>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultVehicleDto>> GetAllVehicleAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Vehicle> GetIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Vehicle> InsertAsync(Vehicle entity)
		{
			throw new NotImplementedException();
		}

		public Task<Vehicle> UpdateAsync(Vehicle entity)
		{
			throw new NotImplementedException();
		}

		public Task UpdateVehicleAsync(int id, UpdateVehicleDto updatedVehicle)
		{
			throw new NotImplementedException();
		}
	}
}
