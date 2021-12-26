using System;

namespace documentation
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Server.Transfer("default.html");
        }
    }
}