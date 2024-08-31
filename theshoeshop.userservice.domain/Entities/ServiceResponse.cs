using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theshoeshop.userservice.domain.Entities
{
    public class ServiceResponse<T>
    {
        public ServiceResponseStatus Status { get; set; }

        public ServiceResponseData<T> ResponseData { get; set; }
    }

    public class ServiceResponseData<T>
    {
        public T Data { get; set; }
    }

    public class ServiceResponseStatus
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<string> Errors { get; set; }
    }
}
