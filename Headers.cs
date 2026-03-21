namespace Header
{
    public class GeneralHeader
    {
        public string Cache_Control { get; set; }
        public string Connection { get; set; }
        public string Date { get; set; }
        public string Pragma { get; set; }
        public string Trailer { get; set; }
        public string TransferEncoding { get; set; }
        public string Via { get; set; }
        public string Upgrade { get; set; }
        public string Warning{ get; set; }
    }

    public class RequestHeader : GeneralHeader 
    {
        public string Message_Body { get; set; }
        public string Accept { get; set; }
        public string Accept_Charset { get; set; }
        public string Accept_Encoding { get; set; }
        public string Accept_Language { get; set; }
        public string Authorization { get; set; }
        public string Expect { get; set; }
        public string From { get; set; }
        public string Host { get; set; }
        public string If_Match { get; set; }
        public string If_Modified_Since { get; set; }
        public string If_None_Match { get; set; }
        public string If_Range { get; set; }
        public string If_Unmodified_Sinc { get; set; }
        public string Max_Forwards { get; set; }
        public string Proxy_Authorizatio { get; set; }
        public string Range { get; set; }
        public string Referer { get; set; }
        public string TE { get; set; }
        public string User_Agent { get; set; }
    }

    public class ResponseHeader : GeneralHeader
    {

    }

    public class EntityHeader : GeneralHeader
    {

    }

}