using MediatR;

namespace CodeChalengeForTest.Application.Command
{
    public class LoginUserCommand : IRequest<LoginUserResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class LoginUserResponse
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
