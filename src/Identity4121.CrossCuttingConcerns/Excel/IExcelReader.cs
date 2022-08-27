namespace Identity4121.CrossCuttingConcerns.Excel
{
    public interface IExcelReader<T>
    {
        T Read(Stream stream);
    }
}
