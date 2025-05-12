using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    List<Band> bands = new List<Band>
    {
        new Band { Id = 1, Name = "Jorn", Description = "Description A" },
        new Band { Id = 2, Name = "Iron Maiden", Description = "Description B" },
        new Band { Id = 3, Name = "Amazarashi", Description = "Description C" }
    };

    public Band[] GetAllBands() =>
        bands.OrderBy(b => b.Name)
        .ToArray();

    public Band? GetBandById(int id) =>
        bands.SingleOrDefault(b => b.Id == id);
}
