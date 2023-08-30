using mercado_api.Enums;

namespace mercado_api.Models;

public class Legume : Alimento
{
    public Legume(string nome, double peso, Ematuridade maturidade = Ematuridade.VERDE) : base(nome, peso, maturidade)
    {
    }
}