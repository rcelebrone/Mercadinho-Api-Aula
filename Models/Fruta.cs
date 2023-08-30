using mercado_api.Enums;

namespace mercado_api.Models;

public class Fruta : Alimento
{
    public Fruta(string nome, double peso, Ematuridade maturidade = Ematuridade.VERDE) : base(nome, peso, maturidade)
    {        
    }

    // As classes que implementarem a interface IAlimento deverão fornecer uma implementação para o método marcado como overide
    // As classes que herdam uma classe com método virtual, permitem que as classes filhas modifiquem esses método
    public override bool EstaProntoParaConsumo() {
        return this.Maturidade == Ematuridade.VENCENDO;
    }
}