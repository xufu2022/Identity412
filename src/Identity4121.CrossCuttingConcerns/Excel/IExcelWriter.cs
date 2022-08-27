namespace Identity4121.CrossCuttingConcerns.Excel
{
    public interface IExcelWriter<T>
    {
        void Write(T data, Stream stream);
    }
}
