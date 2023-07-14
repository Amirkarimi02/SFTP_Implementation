using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Renci.SshNet;
using System.Threading.Tasks;

namespace SFTP_Implementation.Classes
{
    public class SftpManager : IDisposable
    {
        private readonly SftpClient _sftpClient;

        public SftpManager(string host, int port, string username, string password)
        {
            _sftpClient = new SftpClient(host, port, username, password);
        }

        public void Connect()
        {
            _sftpClient.Connect();
        }

        public void Disconnect()
        {
            _sftpClient.Disconnect();
        }

        public void UploadFile(string localFilePath, string remoteDirectory)
        {
            var fileName = Path.GetFileName(localFilePath);
            var remoteFilePath = remoteDirectory + "/" + fileName;

            using (var fileStream = File.OpenRead(localFilePath))
            {
                _sftpClient.UploadFile(fileStream, remoteFilePath);
            }
        }

        public void DownloadFile(string remoteFilePath, string localDirectory)
        {
            var fileName = Path.GetFileName(remoteFilePath);
            var localFilePath = Path.Combine(localDirectory, fileName);

            using (var fileStream = File.OpenWrite(localFilePath))
            {
                _sftpClient.DownloadFile(remoteFilePath, fileStream);
            }
        }

        public void DeleteFile(string remoteFilePath)
        {
            _sftpClient.DeleteFile(remoteFilePath);
        }

        public void RenameFile(string currentRemoteFilePath, string newRemoteFilePath)
        {
            _sftpClient.RenameFile(currentRemoteFilePath, newRemoteFilePath);
        }

        public void CreateDirectory(string remoteDirectory)
        {
            _sftpClient.CreateDirectory(remoteDirectory);
        }

        public void DeleteDirectory(string remoteDirectory)
        {
            _sftpClient.DeleteDirectory(remoteDirectory);
        }

        public void Dispose()
        {
            _sftpClient.Dispose();
        }
    }
}
