﻿namespace Identity4121.Infrastructure.MessageBrokers.AzureEventGrid
{
    public class AzureEventGridOptions
    {
        public string DomainEndpoint { get; set; }

        public string DomainKey { get; set; }

        public Dictionary<string, string> Topics { get; set; }
    }
}
