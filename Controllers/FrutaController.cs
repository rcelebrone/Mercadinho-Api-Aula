using Microsoft.AspNetCore.Mvc;
using mercado_api.Models;
using mercado_api.Services;

namespace mercado_api.Controllers;

[ApiController]
[Route("[controller]")]
public class FrutaController : ControllerBase
{
    private readonly IEnumerable<Fruta> _frutas;

    public FrutaController()
    {
        var service = new FrutaService();
        _frutas = service.Frutas;
    }

    public IEnumerable<Fruta> Get(bool prontaPraConsumo)
    {
        return prontaPraConsumo ? _frutas.Where(fruta => fruta.EstaProntoParaConsumo()) : _frutas;
    }

    // public IEnumerable<string> Nomes()
    // {
    //     return _frutas.Select(f => f.Nome);
    // }
}
