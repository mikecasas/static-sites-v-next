using Microsoft.JSInterop;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class HtmlExportService
{
    private readonly HttpClient _http;
    private readonly IJSRuntime _js;

    public HtmlExportService(HttpClient http, IJSRuntime js)
    {
        _http = http;
        _js = js;
    }

    public async Task DownloadMinifiedHtmlAsync(string url)
    {
        var html = await FetchHtmlAsync(url);
        var minified = MinifyHtml(html);

        var fileName = GenerateFileName(url);

        await _js.InvokeVoidAsync("downloadFile", fileName, minified);
    }

    private async Task<string> FetchHtmlAsync(string url)
    {
        return await _http.GetStringAsync(url);
    }

    private string MinifyHtml(string html)
    {
        if (string.IsNullOrWhiteSpace(html))
            return string.Empty;

        // Remove comments
        html = Regex.Replace(html, @"<!--(.*?)-->", string.Empty, RegexOptions.Singleline);

        // Remove whitespace between tags
        html = Regex.Replace(html, @">\s+<", "><");

        // Collapse multiple spaces
        html = Regex.Replace(html, @"\s{2,}", " ");

        return html.Trim();
    }

    private string GenerateFileName(string url)
    {
        try
        {
            var uri = new Uri(url);
            var host = uri.Host.Replace(".", "_");
            return $"{host}.min.html";
        }
        catch
        {
            return "download.min.html";
        }
    }
}