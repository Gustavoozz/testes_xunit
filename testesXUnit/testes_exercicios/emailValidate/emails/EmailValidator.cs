using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emails
{
    public class EmailValidator
    {
            public static bool IsValidEmail(string email)
            {
                if (string.IsNullOrEmpty(email))
                    return false;

                return email.Contains('@') && email.Contains('.');
            }
        }
    }
