using CodeChalengeForTest.Application.Command;
using CodeChalengeForTest.Domain.IRepository;
using MediatR;

namespace CodeChalengeForTest.Application.CommandHandler
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserResponse>
    {
        private readonly IUserRepository _userRepository;

        public LoginUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginUserResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByUserNameAndPasswordAsync(request.UserName, request.Password);

            if (user == null)
            {
                return new LoginUserResponse
                {
                    Success = false,
                    Message = "Invalid username or password"
                };
            }

            // For demo, fake JWT token
            var token = $"fake-jwt-token-for-{user.UserName}";

            return new LoginUserResponse
            {
                Success = true,
                Token = token,
                Message = "Login successful"
            };
        }
    }
}
