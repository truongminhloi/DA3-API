using DA3.Service.Contract;
using DA3.Service.Request;

namespace DA3.Service.Implement
{
    public class LoginService : ILoginService
    {
        public async Task<bool> Login(LoginRequest request)
        {
            return true;
        }
    }
}
