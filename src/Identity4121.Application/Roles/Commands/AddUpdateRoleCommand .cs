﻿using Identity4121.Application.Common.Commands;

namespace Identity4121.Application.Roles.Commands
{
    public class AddUpdateRoleCommand : ICommand
    {
        public Role Role { get; set; }
    }

    internal class AddUpdateRoleCommandHandler : ICommandHandler<AddUpdateRoleCommand>
    {
        private readonly IRoleRepository _roleRepository;

        public AddUpdateRoleCommandHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task HandleAsync(AddUpdateRoleCommand command, CancellationToken cancellationToken = default)
        {
            await _roleRepository.AddOrUpdateAsync(command.Role);
            await _roleRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
