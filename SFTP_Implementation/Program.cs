using System;
using SFTP_Implementation.Classes;

namespace SFTPConsoleApp
{
    class Program
    {
        static void Main()
        {
            var host = "your_sftp_hostname";
            var port = 22;
            var username = "your_username";
            var password = "your_password";
            var localFilePath = "path_to_local_file.txt";
            var localDirectory = "path_to_local_directory";
            var remoteDirectory = "/remote/directory";
            var remoteFilePath = "/remote/file.txt";

            using (var sftpManager = new SftpManager(host, port, username, password))
            {
                try
                {
                    sftpManager.Connect();

                    // Upload a local file to the SFTP server
                    sftpManager.UploadFile(localFilePath, remoteDirectory);
                    Console.WriteLine("File uploaded successfully.");

                    // Download a file from the SFTP server to a local directory
                    sftpManager.DownloadFile(remoteFilePath, localDirectory);
                    Console.WriteLine("File downloaded successfully.");

                    // Delete a file from the SFTP server
                    sftpManager.DeleteFile(remoteFilePath);
                    Console.WriteLine("File deleted successfully.");

                    // Rename a file on the SFTP server
                    var newRemoteFilePath = "/remote/new_file.txt";
                    sftpManager.RenameFile(remoteFilePath, newRemoteFilePath);
                    Console.WriteLine("File renamed successfully.");

                    // Create a directory on the SFTP server
                    var newRemoteDirectory = "/remote/new_directory";
                    sftpManager.CreateDirectory(newRemoteDirectory);
                    Console.WriteLine("Directory created successfully.");

                    // Delete a directory from the SFTP server
                    sftpManager.DeleteDirectory(newRemoteDirectory);
                    Console.WriteLine("Directory deleted successfully.");

                    sftpManager.Disconnect();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
