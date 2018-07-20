using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExportIssue
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void exportExcel_Click(object sender, EventArgs e)
        {
            Response.Clear();

            Response.Buffer = true;

            Response.AddHeader("content-disposition",

            "attachment;filename=GridViewExport.doc");

            Response.Charset = "";

            Response.ContentType = "application/vnd.ms-word ";

            Response.Output.Write("Hello I am Vivek!");

            Response.Flush();

            Response.End();
            enableButton.Enabled = true;
        }
    }
}