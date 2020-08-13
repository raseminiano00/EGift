using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Infrastructure.Common
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ServiceResponse<T>
    {
        public ServiceResponse(T responseData)
        {
            this.Data = responseData;
            this.Successful = false;
        }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool Successful { get; set; }

        [DataMember]
        public T Data { get; set; }
    }
}
