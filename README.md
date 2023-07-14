# SFTP Implementation

A powerful and easy-to-use SFTP implementation in .NET 7. This project provides a secure way to transfer files to and from an SFTP server.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Error Handling](#error-handling)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- Securely transfer files using the SFTP protocol.
- Upload files to an SFTP server.
- Download files from an SFTP server.
- Manage directories on the server.
- Error handling for common scenarios.
- Configurable options for customization.

## Installation

1. Clone the repository:

   ```
   git clone https://github.com/Amirkarimi02/sftp-implementation.git
   ```

2. Open the project in your preferred IDE.

3. Install the required dependencies:

   ```
   dotnet restore
   ```

4. Build the project:

   ```
   dotnet build
   ```

## Usage

To use the SFTP implementation, follow these steps:

1. Import the necessary namespaces:

   ```
   using SftpImplementation;
   ```

2. Create an instance of the `SftpClient` class:

   ```
   var client = new SftpClient();
   ```

3. Connect to the SFTP server:

   ```
   client.Connect("sftp.example.com", 22, "username", "password");
   ```

4. Perform file transfer operations:

   ```
   // Upload a file
   client.UploadFile("local/path/file.txt", "remote/path/file.txt");

   // Download a file
   client.DownloadFile("remote/path/file.txt", "local/path/file.txt");

   // Create a directory
   client.CreateDirectory("remote/path/new_directory");

   // Delete a file
   client.DeleteFile("remote/path/file.txt");
   ```

5. Disconnect from the SFTP server when finished:

   ```
   client.Disconnect();
   ```

For more advanced usage and configuration options, refer to the [documentation](https://github.com/Amirkarimi02/sftp-implementation/wiki).

## Configuration

The SFTP implementation requires the following configuration settings:

- Hostname: The hostname or IP address of the SFTP server.
- Port: The port number used for the SFTP connection.
- Username: The username for authentication.
- Password: The password for authentication.

To configure these settings, update the values in the `appsettings.json` file:

```
{
  "SftpSettings": {
    "Hostname": "sftp.example.com",
    "Port": 22,
    "Username": "your-username",
    "Password": "your-password"
  }
}
```

## Error Handling

The SFTP implementation includes basic error handling for common scenarios. However, it's recommended to implement additional error handling based on your specific needs.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For any inquiries or questions, please reach out to Amir Karimi at karimika13.ka@gmail.com.

```
