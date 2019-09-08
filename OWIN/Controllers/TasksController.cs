using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWIN.Controllers
{
    public class TasksController: ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "Check E-mail", "Update Documentation", "Refactor Code"};
        }
    }
}
