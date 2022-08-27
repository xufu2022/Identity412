﻿using System.Net;

namespace Identity4121.Infrastructure.Networking
{
    public class FileDownloader : IFileDownloader
    {
        public void DownloadFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(url, path);
        }

        public async Task DownloadFileAsync(string url, string path, CancellationToken cancellationToken = default)
        {
            var client = new WebClient();
            await client.DownloadFileTaskAsync(url, path);
        }
    }
}
