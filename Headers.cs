using System.Text.Json;
using System.Text.Json.Serialization;

namespace Header
{
    public enum Method
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

    public class GeneralHeader
    {
        [JsonPropertyName("Cache-Control")]
        public string Cache_Control { get; set; }
        public string Connection { get; set; }
        public string Date { get; set; }
        public string Pragma { get; set; }
        public string Trailer { get; set; }
        [JsonPropertyName("Transfer-Encoding")]
        public string TransferEncoding { get; set; }
        public string Via { get; set; }
        public string Upgrade { get; set; }
        public string Warning { get; set; }

        
        public GeneralHeader()
        {
            try 
            {
                var g = JsonSerializer.Deserialize<GeneralHeader>(File.ReadAllText("./JSON/headers/general-headers.json"));
                if (g != null)
                {
                    foreach (var prop in typeof(GeneralHeader).GetProperties())
                    {
                        prop.SetValue(this, prop.GetValue(g));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class RequestLine
    {
        public Method Method { get; set; }
        [JsonPropertyName("Request-URI")]
        public string Request_URI { get; set; }
        [JsonPropertyName("HTTP-Version")]
        public string HTTP_Version { get; set; }
    }

    public class RequestHeader : GeneralHeader
    {
        [JsonPropertyName("Request-Line")]
        public RequestLine Request_Line { get; set; } = new RequestLine();
        public string Message_Body { get; set; }
        public string Accept { get; set; }
        public string Accept_Charset { get; set; }
        public string Accept_Encoding { get; set; }
        public string Accept_Language { get; set; }
        public string Authorization { get; set; }
        public string Expect { get; set; }
        public string From { get; set; }
        public string Host { get; set; }
        [JsonPropertyName("If-Match")]
        public string If_Match { get; set; }
        [JsonPropertyName("If-Modified-Since")]
        public string If_Modified_Since { get; set; }
        [JsonPropertyName("If-None-Match")]
        public string If_None_Match { get; set; }
        [JsonPropertyName("If-Range")]
        public string If_Range { get; set; }
        [JsonPropertyName("If-Unmodified-Sinc")]
        public string If_Unmodified_Sinc { get; set; }
        [JsonPropertyName("Max-Forwards")]
        public string Max_Forwards { get; set; }
        [JsonPropertyName("Proxy-Authorizatio")]
        public string Proxy_Authorizatio { get; set; }
        public string Range { get; set; }
        public string Referer { get; set; }
        public string TE { get; set; }
        [JsonPropertyName("User-Agent")]
        public string User_Agent { get; set; }


        public RequestHeader() : base()
        {
            try
            {
                var req = JsonSerializer.Deserialize<RequestHeader>(File.ReadAllText("./JSON/headers/request-headers.json"));
                if (req != null)
                {
                    foreach (var prop in typeof(RequestHeader).GetProperties()) 
                    {
                        if (prop.DeclaringType == typeof(RequestHeader))
                        {
                            prop.SetValue(this, prop.GetValue(req));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class StatusLine
    {
        [JsonPropertyName("HTTP-Version")]
        public string HTTP_Version { get; set; }
        [JsonPropertyName("Status-Code")]
        public string Status_Code { get; set; }
        [JsonPropertyName("Reason-Phrase")]
        public string Reason_Phrase { get; set; }
    }

    public class ResponseHeader : GeneralHeader
    {
        [JsonPropertyName("Status-Line")]
        public string Status_Line { get; set; }
        [JsonPropertyName("Accept-Ranges")]
        public string Accept_Ranges { get; set; }
        public string Age { get; set; }
        public string ETag { get; set; }
        public string Location { get; set; }
        [JsonPropertyName("Proxy-Authenticate")]
        public string Proxy_Authenticate { get; set; }
        [JsonPropertyName("Retry-After")]
        public string Retry_After { get; set; }
        public string Server { get; set; }
        public string Vary { get; set; }
        [JsonPropertyName("WWW-Authenticate")]
        public string WWW_Authenticate { get; set; }

        public ResponseHeader() : base()
        {
            var res = JsonSerializer.Deserialize<ResponseHeader>(File.ReadAllText("./JSON/headers/response-headers.json"));

            foreach (var prop in typeof(ResponseHeader).GetProperties()) 
            {
                prop.SetValue(this, prop.GetValue(res));
            }
        }
    }

    public class EntityHeader
    {
        public string Allow { get; set; }
        [JsonPropertyName("Content-Encoding")]
        public string Content_Encoding { get; set; }
        [JsonPropertyName("Content-Language")]
        public string Content_Language { get; set; }
        [JsonPropertyName("Content-Length")]
        public string Content_Length { get; set; }
        [JsonPropertyName("Content-Location")]
        public string Content_Location { get; set; }
        [JsonPropertyName("Content-MD5")]
        public string Content_MD5 { get; set; }
        [JsonPropertyName("Content-Range")]
        public string Content_Range { get; set; }
        [JsonPropertyName("Content-Type")]
        public string Content_Type { get; set; }
        public string Expires { get; set; }
        [JsonPropertyName("Last-Modified")]
        public string Last_Modified { get; set; }

        public EntityHeader() 
        {
            var e = JsonSerializer.Deserialize<EntityHeader>(File.ReadAllText("./JSON/headers/entity-headers.json"));

            foreach (var prop in typeof(EntityHeader).GetProperties())
            {
                prop.SetValue(this, prop.GetValue(e));
            }
        }
    }
}