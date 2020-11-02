using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Checkers
{
    public static class CheckEmailRule
    {
        public static string IsValidEmail(this string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return "";
            }
            catch(FormatException)
            {
                return "Formato de email inválido";
            }
            catch (ArgumentNullException)
            {
                return "Email deve ser informado.";
            }
        }
    }
}
