using mercado_api.Enums;

namespace mercado_api.Models.Interfaces;

interface IAlimento
{
    public String Nome { get; }
    public double Peso { get; }
    public Ematuridade Maturidade { get; set; }

    // A palavra-chave abstract em métodos dentro de uma interface no C# serve para indicar que o método não tem implementação
    // Isso significa que as classes que implementarem a interface deverão fornecer suas próprias implementações para o método
    abstract public bool EstaProntoParaConsumo();
}