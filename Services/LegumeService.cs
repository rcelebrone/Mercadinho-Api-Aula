using mercado_api.Models;
using mercado_api.Enums;

namespace mercado_api.Services;

public class LegumeService {

    public IEnumerable<Legume> Legumes { get; set; }

    public LegumeService ()
    {
        var legumes = new List<Legume>();

        legumes.Add(new Legume("Pepino", 0.5));
        legumes.Add(new Legume("Abobrinha", 0.6));
        legumes.Add(new Legume("Chuchu", 0.35, Ematuridade.MADURO));
        legumes.Add(new Legume("Abobora", 0.87));
        legumes.Add(new Legume("Berinjela", 0.5, Ematuridade.MADURO));
        legumes.Add(new Legume("Jiló", 0.12));

        this.Legumes = legumes;
    }
}