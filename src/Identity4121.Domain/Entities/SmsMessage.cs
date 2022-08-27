﻿using Identity4121.Domain.Notification;

namespace Identity4121.Domain.Entities
{
    public class SmsMessage : AggregateRoot<Guid>, ISmsMessage
    {
        public string Message { get; set; }

        public string PhoneNumber { get; set; }

        public int AttemptCount { get; set; }

        public int MaxAttemptCount { get; set; }

        public DateTimeOffset? NextAttemptDateTime { get; set; }

        public DateTimeOffset? ExpiredDateTime { get; set; }

        public string Log { get; set; }

        public DateTimeOffset? SentDateTime { get; set; }

        public Guid? CopyFromId { get; set; }
    }
}
