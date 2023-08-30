using mercado_api.Models;
using mercado_api.Models.Interfaces;

namespace mercado_api.Services.Interfaces;

interface IAlimentoService<T> {

    public IEnumerable<T> Alimentos { get; set; }

}