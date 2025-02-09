using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Updater.Service
{
    public class FileDownlaod
    {
        private volatile bool   _completed;
        private WebClient       _client;
        private const string    FILE_TEMP = "update.temp";
        private string          _location;
        private string          _Url;
        public string           FileLocation    { get; set; }

        public AsyncCompletedEventHandler AsyncCompletedEventHandler;
        public DownloadProgressChangedEventHandler  DownloadProgressChangedEventHandler;

        public void DownloadFile(string Url, string FolderLocation)
        {
            _client             = new WebClient();
            _Url                = Url;
            Uri Uri             = new Uri(Url);
            _location           = FolderLocation;
            _completed          = false;
            var temp            = Path.Combine(FolderLocation, "update.temp");

            _client.DownloadFileCompleted       += new AsyncCompletedEventHandler(Completed);
            _client.DownloadProgressChanged     += new DownloadProgressChangedEventHandler(DownloadProgress);
            _client.DownloadFileAsync           (Uri, temp);
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {

            DownloadProgressChangedEventHandler?.Invoke(sender,e);
            
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled )
            {
                _completed = true;
                RenameFile();
                AsyncCompletedEventHandler?.Invoke(sender, e);
            }
        }

        private void RenameFile()
        {
            //_client.OpenRead(_Url);
            string header_contentDisposition    = _client.ResponseHeaders["content-disposition"];
            string filename                     = new ContentDisposition(header_contentDisposition).FileName;

            if(string.IsNullOrEmpty(filename))
                return;

            var source  = Path.Combine(_location, FILE_TEMP);
            var dest    = Path.Combine(_location, filename);

            if(File.Exists(dest))
                File.Delete(dest);

            File.Move(source,dest);
            FileLocation = dest;
        }





    }
}
