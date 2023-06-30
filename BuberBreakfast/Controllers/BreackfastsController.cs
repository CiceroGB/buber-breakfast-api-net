using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Controllers;


[ApiController]
public class BreakfastController : ControllerBase
{
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        var response = new { msg = "ok"};
        return Ok(response);
}

[HttpPut("/breakfasts/{id:guid}")]
public IActionResult UpdateBreakfast(Guid id, UpsertBreakfastRequest request)
{
    return Ok(request);
}

[HttpDelete("/breakfasts/{id:guid}")]
public IActionResult DeleteBreakfast(Guid id)
{
    return Ok(id);
}


}


