using BlazorWasmProject.Server.Interfaces;
using BlazorWasmProject.Server.Models;
using BlazorWasmProject.Shared;

namespace BlazorWasmProject.Server.Services
{
    public class GangnamguPopulationService : IGangnamguPopulation
    {
        private readonly BlazorWasmDbContext _dbContext;

        public GangnamguPopulationService(BlazorWasmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddGangnamguPopulation(GangnamguPopulation population)
        {
            try
            {
                _dbContext.GangnamguPopulations.Add(population);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteGangnamguPopulation(int id)
        {
            try
            {
                GangnamguPopulation? gangnamguPopulation = _dbContext.GangnamguPopulations.Find(id);
                if (gangnamguPopulation != null)
                {
                    _dbContext.GangnamguPopulations.Remove(gangnamguPopulation);
                    _dbContext.SaveChanges();
                }
                else 
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GangnamguPopulation> GetAllGangnamguPopulation()
        {
            try
            {
                return _dbContext.GangnamguPopulations.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GangnamguPopulation GetGangnamguPopulation(int id)
        {
            try
            {
                GangnamguPopulation? gangnamguPopulation = _dbContext.GangnamguPopulations.Find(id);
                if (gangnamguPopulation != null)
                {
                    return gangnamguPopulation;
                }
                else 
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateGangnamguPopulation(GangnamguPopulation population)
        {
            try
            {
                _dbContext.GangnamguPopulations.Update(population);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
