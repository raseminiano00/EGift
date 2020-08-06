﻿namespace EGift.Infrastructure.Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Response
    {
        public Response()
        {
            this.Successful = true;
        }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool Successful { get; set; }
    }
}