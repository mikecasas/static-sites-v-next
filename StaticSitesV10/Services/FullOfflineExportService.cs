using Microsoft.JSInterop;
using System.Text.RegularExpressions;

namespace StaticSitesV10.Services
{

    public class FullOfflineExportService
    {
        private readonly IJSRuntime _js;

        public FullOfflineExportService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task DownloadAsync(string url)
        {
            var html = await _js.InvokeAsync<string>("fullOfflineExport", url);

            var minified = Minify(html);

            await _js.InvokeVoidAsync(
                "downloadFile",
                GenerateFileName(url),
                minified
            );
        }

        private string Minify(string html)
        {
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
                return $"{uri.Host.Replace(".", "_")}_offline.html";
            }
            catch
            {
                return "offline.html";
            }
        }
    }
}