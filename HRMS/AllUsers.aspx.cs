using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS
{
    public partial class AllUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AllData();
        }

        private void AllData()
        {
            var list = UsersDAL.FetchList();

            if (list.Count > 0)
            {
                gvList.DataSource = list;
                gvList.DataBind();

                gvList.UseAccessibleHeader = true;
                gvList.HeaderRow.TableSection = TableRowSection.TableHeader;
                gvList.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }
    }
}