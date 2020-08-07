namespace EGift.Infrastructure.Common
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Response<T> 
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
        T Data { get; set; }
    }
}
