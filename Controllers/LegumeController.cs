using Microsoft.AspNetCore.Mvc;
using mercado_api.Models;
using mercado_api.Services;

namespace mercado_api.Controllers;

[ApiController]
[Route("[controller]")]
public class LegumeController : ControllerBase
{
    private readonly IEnumerable<Legume> _legumes;

    public LegumeController()
    {
        var service = new LegumeService();
        _legumes = service.Alimentos; 
    }

    public IEnumerable<Legume> Get(bool prontaPraConsumo)
    {
        return prontaPraConsumo ? _legumes.Where(legume => legume.EstaProntoParaConsumo()) : _legumes;
    }
}