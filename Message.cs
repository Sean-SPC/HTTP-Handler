using System.ComponentModel;
using System.Dynamic;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Message
{
    private string Host;
    public string HOST { get { return Host; } set { Host = value; } }
    private int Port;
    public int PORT { get { return Port; } set{ Port = value; } }
    private string Http_Version = "1.1";
    public string HTTP_VERSION { get { return Http_Version; } set { Http_Version = value; }}
    private DateTime Date = DateTime.Today;
    public DateTime DATE { get { return Date; } set { Date = value; } }
    public enum HTTP_TYPE
    {
        REQUEST,
        RESPONSE
    }
    private HTTP_TYPE Type;
    public HTTP_TYPE TYPE { get { return Type; } set { Type = value; }}

    // CONSTRUCTOR
    public Message(string host, int port, string type, string method)
    {
        this.Host = host;
        this.Port = port;
    }
}