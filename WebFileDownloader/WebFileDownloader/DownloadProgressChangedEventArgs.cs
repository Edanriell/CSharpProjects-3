namespace WebFileDownloader
{
    public class DownloadProgressChangedEventArgs
    {
        // You could base this on ProgressChangedEventArgs in System.ComponentModel
        public DownloadProgressChangedEventArgs(int progressPercentage, long bytesReceived)
        {
            ProgressPercentage = progressPercentage;
            BytesReceived = bytesReceived;
        }

        public long BytesReceived { get; init; }
        public int ProgressPercentage { get; init; }
    }
}
