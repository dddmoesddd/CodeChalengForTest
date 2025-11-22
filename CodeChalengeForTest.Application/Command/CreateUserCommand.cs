using MediatR;

public record CreateUserCommand(
    string FirstName,
    string LastName,
    string Phone,
    string Email,
    string UserName,
    string Password,
    Address Address
) : IRequest<Guid>;
