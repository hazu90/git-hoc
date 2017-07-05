using SeafoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SeafoodAPI.IServices
{
    [ServiceContract]
    public interface ICity
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Create",
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedResponse,
            ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "result")]
        ResponseModel Create(RequestModel model);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Update",
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedResponse,
            ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "result")]
        ResponseModel Update(RequestModel model);
    }
}
