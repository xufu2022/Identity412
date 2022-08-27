﻿using Identity4121.Application.Common.Commands;

namespace Identity4121.Application.Users.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public User User { get; set; }
    }

    internal class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(DeleteUserCommand command, CancellationToken cancellationToken = default)
        {
            _userRepository.Delete(command.User);
            await _userRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
