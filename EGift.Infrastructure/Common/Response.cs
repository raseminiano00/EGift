namespace EGift.Infrastructure.Common
{
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.Serialization;

    [DataContract]
    public class Response
    {
        public Response()
        {
            this.Successful = false;
        }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool Successful { get; set; }

        [DataMember]
        public DataTable RawData { get; set; }
    }
}
