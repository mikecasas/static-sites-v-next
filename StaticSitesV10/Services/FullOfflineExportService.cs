using Microsoft.JSInterop;
using System.Net.Mime;
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

        public async Task DownloadAsync(string url, string fileName)
        {
            //byte[] MyFile = Enumerable.Range(0, 100).Cast<byte>().ToArray();
            //string FileName = "file.bin";
            //string ContentType = "application/octet-stream";

            var html = await _js.InvokeAsync<string>("fullOfflineExport", url);

            var minified = Minify(html);

            await _js.InvokeVoidAsync(
                "downloadFile",
                GenerateFileName(fileName),
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

        private string GenerateFileName(string fileName)
        {
            try
            {
                //var uri = new Uri(url);
                //return $"{uri.Host.Replace(".", "_")}_offline.html";

                return $"{fileName}.html";

            }
            catch
            {
                return "offline.html";
            }
        }
    }
}