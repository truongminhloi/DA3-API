using DA3.Service.Contract;
using DA3.Service.Request;
using Microsoft.AspNetCore.Mvc;

namespace DA3.Controler
{
    [Route("api/authen")]
    public class LoginController
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<bool> Login (LoginRequest request)
        {
            return await _loginService.Login(request);
        }
    }
}
