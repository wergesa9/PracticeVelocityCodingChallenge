using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;

namespace CodeChallenge.Helper
{
    public class MyXmlReader
    {
        public List<string> GetButtonsFromXml()
        {
            string buttonXml = HttpContext.Current.Server.MapPath("~/App_Data/buttons.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(buttonXml);
            List<string> buttons = new List<string>();
            buttons = (from rows in ds.Tables[0].AsEnumerable()
                       select rows[0].ToString()).ToList();
            return buttons;
        }
    }
}
