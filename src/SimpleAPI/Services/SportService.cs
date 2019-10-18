using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleAPI.Domain.Models;
using SimpleAPI.Domain.Repositories;
using SimpleAPI.Domain.Services;

using SimpleAPI.Domain.Services.Communication;

namespace SimpleAPI.Services
{
    public class SportService : ISportService
    {
        private readonly ISportRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public SportService(ISportRepository repo, IUnitOfWork unitOfWork)
        {
            _repository = repo;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Sport>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<SportResponse> SaveAsync(Sport sport)
        {
            try
		    {
			    await _repository.AddAsync(sport);
			    await _unitOfWork.CompleteAsync();
			    return new SportResponse(sport);
		    }
		    catch (System.Exception ex)
		    {
			    // Do some logging stuff
			    return new SportResponse($"An error occurred when saving the category: {ex.Message}");
		    }
        }

        public async Task<SportResponse> UpdateAsync(int id, Sport category)
        {
            var existingSport = await _repository.FindByIdAsync(id);

            if (existingSport == null)
                return new SportResponse("Sport not found.");

            existingSport.Name = category.Name;

            try
            {
                _repository.Update(existingSport);
                await _unitOfWork.CompleteAsync();

                return new SportResponse(existingSport);
            }
            catch (System.Exception ex)
            {
                // Do some logging stuff
                return new SportResponse($"An error occurred when updating the sport: {ex.Message}");
            }
        }

        public async Task<SportResponse> DeleteAsync(int id)
        {
            var existingSport = await _repository.FindByIdAsync(id);

            if (existingSport == null)
                return new SportResponse("Sport not found.");

            try
            {
                _repository.Remove(existingSport);
                await _unitOfWork.CompleteAsync();

                return new SportResponse(existingSport);
            }
            catch (System.Exception ex)
            {
                // Do some logging stuff
                return new SportResponse($"An error occurred when deleting the sport: {ex.Message}");
            }
        }
    }
}