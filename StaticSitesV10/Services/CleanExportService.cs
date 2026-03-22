using Microsoft.JSInterop;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaticSitesV10.Services
{
    public class CleanExportService
    {
        private readonly IJSRuntime _js;

        public CleanExportService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task DownloadCleanFromUrlAsync(string url)
        {
            try
            {
                var html = await _js.InvokeAsync<string>("cleanExportFromUrl", url);

                var minified = MinifyHtml(html);

                var fileName = GenerateFileName(url);

                await _js.InvokeVoidAsync("downloadFile", fileName, minified);
            }
            catch (JSException ex)
            {
                Console.WriteLine($"Export failed: {ex.Message}");
            }
        }

        private string MinifyHtml(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
                return string.Empty;

            html = Regex.Replace(html, @"<!--(.*?)-->", "", RegexOptions.Singleline);
            html = Regex.Replace(html, @">\s+<", "><");
            html = Regex.Replace(html, @"\s{2,}", " ");

            return html.Trim();
        }

        private string GenerateFileName(string url)
        {
            try
            {
                var uri = new Uri(url);
                return $"{uri.Host.Replace(".", "_")}_clean.html";
            }
            catch
            {
                return "clean-export.html";
            }
        }
    }
}