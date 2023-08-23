using mercado_api.Enums;

namespace mercado_api.Models;

public class Fruta
{
    public String Nome { get; private set; }
    public double Peso { get; private set; }
    public Ematuridade Maturidade { get; set; }

    public Fruta(string nome, double peso, Ematuridade maturidade = Ematuridade.VERDE) {

        // regra para garantir que toda fruta terá um nome
        if (nome == null) throw new ArgumentNullException(nameof(nome));

        // regra para garantir que toda fruta tem um peso
        if (peso == 0) throw new ArgumentNullException(nameof(peso));

        this.Nome = nome;
        this.Peso = peso;
        this.Maturidade = maturidade;
    }

    public bool EstaProntoParaConsumo() {
        return this.Maturidade == Ematuridade.MADURO;
    }
}