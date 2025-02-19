using ChustKnife.Application.Common.Exceptions;
using ChustKnife.Domain.Enums;
using ChustKnife.WebUI.Middlewares;
using Microsoft.AspNetCore.Mvc;

namespace ChustKnife.WebUI.Controllers;

public class AuthController : BaseController
{
    [CustomAuthorize(nameof(UserRole.Client))]
    [HttpPost]
    public async ValueTask<IActionResult> GetCode()
    {
        throw new NotFoundException("user", "id");
        return Ok();
    }
}