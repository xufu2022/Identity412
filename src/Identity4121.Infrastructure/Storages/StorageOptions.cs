using Identity4121.Infrastructure.Storages.Amazon;
using Identity4121.Infrastructure.Storages.Azure;
using Identity4121.Infrastructure.Storages.Local;

namespace Identity4121.Infrastructure.Storages
{
    public class StorageOptions
    {
        public string Provider { get; set; }

        public LocalOptions Local { get; set; }

        public AzureBlobOption Azure { get; set; }

        public AmazonOptions Amazon { get; set; }

        public bool UsedLocal()
        {
            return Provider == "Local";
        }

        public bool UsedAzure()
        {
            return Provider == "Azure";
        }

        public bool UsedAmazon()
        {
            return Provider == "Amazon";
        }

        public bool UsedFake()
        {
            return Provider == "Fake";
        }
    }
}
