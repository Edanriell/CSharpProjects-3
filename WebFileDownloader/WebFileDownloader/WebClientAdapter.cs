using System.Net;

namespace WebFileDownloader
{
    public class WebClientAdapter
    {
        public event EventHandler DownloadCompleted;
        public event EventHandler<DownloadProgressChangedEventArgs> DownloadProgressChanged;
        public event EventHandler<string> InvalidUrlRequested;

        public IDisposable DownloadFile(string url, string destination)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                InvalidUrlRequested?.Invoke(this, url);
                return null;
            }

            var client = new WebClient();

            client.DownloadFileCompleted += (sender, args) =>
                DownloadCompleted?.Invoke(this, EventArgs.Empty);

            client.DownloadProgressChanged += (sender, args) =>
                DownloadProgressChanged?.Invoke(
                    this,
                    new DownloadProgressChangedEventArgs(
                        args.ProgressPercentage,
                        args.BytesReceived
                    )
                );

            client.DownloadFileAsync(uri, destination);

            return client;
        }
    }
}
