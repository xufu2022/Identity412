﻿using Identity4121.Application.Common.Commands;

namespace Identity4121.Application.Common
{
    internal static class Utils
    {
        public static bool IsHandlerInterface(Type type)
        {
            if (!type.IsGenericType)
            {
                return false;
            }

            var typeDefinition = type.GetGenericTypeDefinition();

            return typeDefinition == typeof(ICommandHandler<>)
                || typeDefinition == typeof(IQueryHandler<,>);
        }
    }
}