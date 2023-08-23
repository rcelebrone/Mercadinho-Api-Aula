using mercado_api.Models;
using mercado_api.Enums;

namespace mercado_api.Services;

public class FrutaService {

    public IEnumerable<Fruta> Frutas { get; set; }

    public FrutaService()
    {
        var frutas = new List<Fruta>();

        frutas.Add(new Fruta("Banana", 0.25)); 
        frutas.Add(new Fruta("Maça", 0.35, Ematuridade.MADURO));
        frutas.Add(new Fruta("Uva", 0.3));
        frutas.Add(new Fruta("Melancia", 0.45, Ematuridade.MADURO));
        frutas.Add(new Fruta("Abacaxi", 0.5));
        frutas.Add(new Fruta("Pera", 0.4));

        this.Frutas = frutas;
    }
}