namespace Identity4121.CrossCuttingConcerns.Csv
{
    public interface ICsvWriter<T>
    {
        void Write(IEnumerable<T> collection, Stream stream);
    }
}
