using mercado_api.Enums;

namespace mercado_api.Models;

public class Legume
{
    public String Nome { get; private set; }
    public double Peso { get; private set; }
    public Ematuridade Maturidade { get; set; }

    public Legume(string nome, double peso, Ematuridade maturidade = Ematuridade.VERDE) {

        if (nome == null) throw new ArgumentNullException(nameof(nome));

        if (peso == 0) throw new ArgumentNullException(nameof(peso));

        this.Nome = nome;
        this.Peso = peso;
        this.Maturidade = maturidade;
    }

    public bool EstaProntoParaConsumo() {
        return this.Maturidade == Ematuridade.MADURO;
    }

}