﻿namespace Identity4121.CrossCuttingConcerns.Tenants
{
    public interface ITenantResolver
    {
        Tenant Tenant { get; }
    }

    public class Tenant
    {
        public string Id { get; }
        public string Name { get; }
        public string ConnectionString { get; }
    }
}
