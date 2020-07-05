using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace ASP7._2.Services
{
    [WebService(Namespace = "http://julia.org/")]                 //пр-во имен (smw60.by)
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]   //спецификация совместимости веб-служб
    [System.ComponentModel.ToolboxItem(false)]                      //управление панелью эл-тов VS ToolBox


    public class WebService : System.Web.Services.WebService
    {
        private int x = 0;

        [WebMethod(Description = "Установить значение x", EnableSession = true)]
        public void SetX(int x)
        {
            //this.x = x;
            this.Session["x"] = x;
        }

        [WebMethod(Description = "Получить значение x", EnableSession = true)]
        public int GetX()
        {
            //return this.x;
            int rc = 777;
            if (this.Session["x"] != null) rc = (int)this.Session["x"];
            return rc;
        }

        [WebMethod(Description = "Увеличить На x и вернуть", EnableSession = true)]
        public int AddX(int x)
        {
            //return this.x += x;
            int rc = 777;
            if (this.Session["x"] != null) rc = (int)this.Session["x"] + x;
            return rc;
        }
    }
}

//http://localhost:49828/Services/WebService.asmx?wsdl