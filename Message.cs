using System.ComponentModel;
using System.Net;

class Message
{
    private string Host;
    public string HOST { get { return Host; } set { Host = value; } }
    private int Port;
    public int PORT { get { return Port; } set{ Port = value; } }
    private string Http_Version = "1.1";
    public string HTTP_VERSION { get { return Http_Version; } set { Http_Version = value; }}
    public enum HTTP_TYPE
    {
        REQUEST,
        RESPONSE
    }
    private HTTP_TYPE Type;
    public HTTP_TYPE TYPE { get { return Type; } set { Type = value; }}
    public enum HTTP_METHOD
    {
        OPTIONS,
        GET,
        HEAD,
        POST,
        PUT,
        DELETE,
        TRACE,
        CONNECT,
    }
    private HTTP_METHOD Method;
    public HTTP_METHOD METHOD { get { return Method; } set { Method = value; }}

    // CONSTRUCTOR
    public Message(string host, int port, string type, string method)
    {
        this.Host = host;
        this.Port = port;
        if (!Enum.TryParse<HTTP_TYPE>(type, true, out this.Type))
        {
            throw new ArgumentException($"Invalid HTTP Type: {type}");
        }
        if (!Enum.TryParse<HTTP_METHOD>(method, true, out this.Method))
        {
            throw new ArgumentException($"Invalid HTTP method: {method}");
        }
    }

    // CONSTRUCTOR - NO TYPE | NO METHOD
    public Message(string host, int port)
    {
        this.HOST = host;
        this.PORT = port;
        this.TYPE = HTTP_TYPE.REQUEST;
        this.METHOD = HTTP_METHOD.GET;
    }

    // DEFAULT CONSTRUCTOR
    public Message()
    {
    }

    public void print()
    {
        Console.WriteLine("| REQUEST |");
        Console.WriteLine("Host : " + this.HOST);
        Console.WriteLine("Port : " + this.PORT);
        Console.WriteLine("Type : " + this.TYPE);
        Console.WriteLine("Method : " + this.METHOD);
    }
}