using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Services.BaseService
{
    public abstract class BaseServiceParams: IBaseServiceParams
    {
        public string UserId
        {
            get;
            set;
        }
        public Guid RequestId
        {
            get;
            set;
        }
    }
}
