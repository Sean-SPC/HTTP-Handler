using System.Net.Sockets;
using System.Net.Security;
using System.Text;
using System.Text.Json;
using Header;

// // Relevant Attributes
// string targetHost = "www.example.com";
// int port = 443;

// // Creating Headers
try 
{
    RequestHeader request = new RequestHeader();
    Console.WriteLine("request: ");
    Thread.Sleep(10000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// // Creating HTTP Message Object
// Message message = new Message(targetHost, port);

// string responseOutputFilePath = $"./output/{message.METHOD}_{message.HOST}_{message.HTTP_VERSION}_{message.DATE.Second}.txt";

//  // Connect via TCP
// using TcpClient tcpClient = new TcpClient(message.HOST, message.PORT);

// // Wrap TCP stream in SslStream for TLS
// using SslStream sslStream = new SslStream(tcpClient.GetStream(), false);
// sslStream.AuthenticateAsClient(message.HOST);

// // Build HTTP GET request
// string request = $"GET / HTTP/1.1\r\n" +
//                     $"Host: {message.HOST}\r\n" +
//                     $"Connection: close\r\n" +
//                     $"Date: {message.DATE}\r\n\r\n";

// File.WriteAllText(responseOutputFilePath, "| REQUEST |\r\n\r\n" + request);

// // Convert request to bytes and send
// byte[] requestBytes = Encoding.ASCII.GetBytes(request);
// sslStream.Write(requestBytes);
// sslStream.Flush();

// // Read response into a StringBuilder
// StringBuilder responseBuilder = new StringBuilder();
// byte[] buffer = new byte[4096];
// int bytesRead;

// while ((bytesRead = sslStream.Read(buffer, 0, buffer.Length)) > 0)
// {
//     string chunk = Encoding.ASCII.GetString(buffer, 0, bytesRead);
//     responseBuilder.Append(chunk);
// }

// // Write entire response to file
// File.AppendAllText(responseOutputFilePath, "| RESPONSE |\r\n\r\n" + responseBuilder.ToString());
// Console.WriteLine("Response saved to " + responseOutputFilePath);