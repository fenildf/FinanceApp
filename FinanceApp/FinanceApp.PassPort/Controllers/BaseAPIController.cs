using System.Web.Http;
using System.Web.Script.Serialization;
using log4net;

namespace FinanceApp.PassPort.Controllers
{
    public abstract class BaseAPIController<T> : ApiController
    {
        protected readonly ILog log = LogManager.GetLogger(typeof (T));
        protected readonly JavaScriptSerializer serializer = new JavaScriptSerializer();
    }
}
