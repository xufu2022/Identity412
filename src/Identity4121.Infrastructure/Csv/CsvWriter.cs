﻿namespace Identity4121.Infrastructure.Csv
{
    public class CsvWriter<T> : ICsvWriter<T>
    {
        public void Write(IEnumerable<T> collection, Stream stream)
        {
            using var writer = new StreamWriter(stream);
            using var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(collection);
        }
    }
}
