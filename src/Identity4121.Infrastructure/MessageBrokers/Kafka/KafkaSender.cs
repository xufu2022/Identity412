﻿using System.Text.Json;
using Confluent.Kafka;

namespace Identity4121.Infrastructure.MessageBrokers.Kafka
{
    public class KafkaSender<T> : IMessageSender<T>, IDisposable
    {
        private readonly string _topic;
        private readonly IProducer<Null, string> _producer;

        public KafkaSender(string bootstrapServers, string topic)
        {
            _topic = topic;

            var config = new ProducerConfig { BootstrapServers = bootstrapServers };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public void Dispose()
        {
            _producer.Flush(TimeSpan.FromSeconds(10));
            _producer.Dispose();
        }

        public async Task SendAsync(T message, MetaData metaData, CancellationToken cancellationToken = default)
        {
            _ = await _producer.ProduceAsync(_topic, new Message<Null, string>
            {
                Value = JsonSerializer.Serialize(new Message<T>
                {
                    Data = message,
                    MetaData = metaData,
                }),
            }, cancellationToken);
        }
    }
}