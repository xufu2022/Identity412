using Microsoft.Extensions.Configuration;

namespace Identity4121.Infrastructure.Configuration
{
    public static class SqlConfigurationExtensions
    {
        /// <summary>
        ///     Adds an Microsoft.Extensions.Configuration.IConfigurationProvider that reads
        ///    configuration values from a custom table in the Sql Server Database.
        /// </summary>
        /// <param name="builder">The Microsoft.Extensions.Configuration.IConfigurationBuilder to add to.</param>
        /// <param name="options">Connection String to the database & Sql Query to get variables.</param>
        /// <returns>The Microsoft.Extensions.Configuration.IConfigurationBuilder.</returns>
        public static IConfigurationBuilder AddSqlConfigurationVariables(this IConfigurationBuilder builder, SqlServerOptions options)
        {
            return builder.Add(new SqlConfigurationSource(options));
        }
    }
}
