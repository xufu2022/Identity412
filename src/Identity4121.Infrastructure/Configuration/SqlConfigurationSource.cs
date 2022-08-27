using Microsoft.Extensions.Configuration;

namespace Identity4121.Infrastructure.Configuration
{
    public class SqlConfigurationSource : IConfigurationSource
    {
        private readonly SqlServerOptions _options;

        public SqlConfigurationSource(SqlServerOptions options)
        {
            _options = options;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new SqlConfigurationProvider(_options);
        }
    }
}
