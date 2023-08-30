using mercado_api.Enums;
using mercado_api.Models.Interfaces;

namespace mercado_api.Models;

public class Alimento : IAlimento
{
    public String Nome { get; private set; }
    public double Peso { get; private set; }
    public Ematuridade Maturidade { get; set; }

    public Alimento(string nome, double peso, Ematuridade maturidade = Ematuridade.VERDE) {

        // regra para garantir que toda fruta terá um nome
        if (nome == null) throw new ArgumentNullException(nameof(nome), "Do que estamos falando?");

        // regra para garantir que toda fruta tem um peso
        if (peso == 0) throw new ArgumentNullException(nameof(peso), "Todo alimento tem peso, informe!");

        this.Nome = nome;
        this.Peso = peso;
        this.Maturidade = maturidade;
    }

    // A palavra-chave virtual deve ser usada quando um método deve ser sobreescrito por uma classe derivada.
    // Isso permite que as classes derivadas implementem o método de forma diferente, dependendo de suas necessidades. 
    virtual public bool EstaProntoParaConsumo() {
        return this.Maturidade == Ematuridade.MADURO;
    }
}