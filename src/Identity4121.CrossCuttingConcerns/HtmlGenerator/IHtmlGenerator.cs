namespace Identity4121.CrossCuttingConcerns.HtmlGenerator
{
    public interface IHtmlGenerator
    {
        Task<string> GenerateAsync(string template, object model);
    }
}
