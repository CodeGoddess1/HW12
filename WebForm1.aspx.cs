using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using Palindrome;

namespace Palindrome.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string EnterWord = string.Empty;
            Console.Write("Enter text to see if it’s a palindrome    ");
            EnterWord = Console.ReadLine();

        }

        protected void UserInPut_TextChanged(object sender, EventArgs e)
        {
            UserInPut.Text
           
            

        }

        protected void UserOutPut_TextChanged(object sender, EventArgs e)
        {
            EnterWordReversed = Paldrm.GetText(EnterWord);
            string EnterWord = string.Empty;
            string EnterWordReversed = string.Empty;
        }
    }
}