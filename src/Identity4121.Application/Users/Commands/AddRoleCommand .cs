﻿using Identity4121.Application.Common.Commands;

namespace Identity4121.Application.Users.Commands
{
    public class AddRoleCommand : ICommand
    {
        public User User { get; set; }
        public UserRole Role { get; set; }
    }

    internal class AddRoleCommandHandler : ICommandHandler<AddRoleCommand>
    {
        private readonly IUserRepository _userRepository;

        public AddRoleCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(AddRoleCommand command, CancellationToken cancellationToken = default)
        {
            command.User.UserRoles.Add(command.Role);
            await _userRepository.AddOrUpdateAsync(command.User);
            await _userRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
