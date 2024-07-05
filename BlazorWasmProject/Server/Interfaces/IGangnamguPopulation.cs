using BlazorWasmProject.Shared;

namespace BlazorWasmProject.Server.Interfaces
{
    public interface IGangnamguPopulation
    {
        public void AddGangnamguPopulation(GangnamguPopulation population);

        public void UpdateGangnamguPopulation(GangnamguPopulation population);

        public void DeleteGangnamguPopulation(int id);

        public GangnamguPopulation GetGangnamguPopulation(int id);

        public List<GangnamguPopulation> GetAllGangnamguPopulation();
    }
}
