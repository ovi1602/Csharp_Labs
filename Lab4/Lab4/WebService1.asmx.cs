using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebService(Description = "Serviciu Web pentru Cursul de C#", Name = "My first web service", Namespace ="Web Services")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        List<string> lista = new List<string>()
        {
            "element1","element2","element3","element4","element5"
        };
       

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public double FtoC(double x)
        {
            return (x - 32) * 5 / 9;
        }

        [WebMethod]
        public double CtoF(double x)
        {
            return x * 9 / 5 + 32;
        }

        [WebMethod]
        public string ShowDateAndTime()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public double ConvertToEuro(double x)
        {
            return x / 4.75;
        }

        [WebMethod]
        public List<string> ShowList()
        {
            return this.lista;
        }
    }
}
