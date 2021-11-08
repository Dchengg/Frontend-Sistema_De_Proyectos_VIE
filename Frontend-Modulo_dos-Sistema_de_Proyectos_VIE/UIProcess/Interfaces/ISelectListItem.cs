using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UIProcess.Interfaces
{
    public interface ISelectListItem
    {
        SelectListItem ToSelectListItem();
    }
}
