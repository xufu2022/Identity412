﻿using System.ComponentModel.DataAnnotations;

namespace Identity4121.Domain.Entities
{
    public abstract class Entity<TKey> : IHasKey<TKey>, ITrackable
    {
        public TKey Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; }

        public DateTimeOffset? UpdatedDateTime { get; set; }
    }
}
