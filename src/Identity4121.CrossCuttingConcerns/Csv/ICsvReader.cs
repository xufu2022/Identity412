namespace Identity4121.CrossCuttingConcerns.Csv
{
    public interface ICsvReader<T>
    {
        IEnumerable<T> Read(Stream stream);
    }
}
