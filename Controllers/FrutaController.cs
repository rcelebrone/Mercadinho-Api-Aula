using Microsoft.AspNetCore.Mvc;
using mercado_api.Models;
using mercado_api.Services;

namespace mercado_api.Controllers;

[ApiController]
[Route("[controller]")]
public class FrutaController : ControllerBase
{
    private List<Fruta> _frutas;
    private readonly FrutaService _frutaService;

    public FrutaController(FrutaService frutaService) {
        _frutaService = frutaService;
        _frutas = _frutaService.Alimentos.ToList();
    }

    [HttpGet]
    public IEnumerable<Fruta> Recuperar(bool prontaPraConsumo)
    {
        return prontaPraConsumo ? _frutas.Where(fruta => fruta.EstaProntoParaConsumo()) : _frutas;
    }

    [HttpPost]
    public IEnumerable<Fruta> Gravar([FromBody] Fruta fruta) {
        _frutas.Add(fruta);

        return _frutas;
    }
}
