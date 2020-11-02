using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Checkers
{
    class CheckAnyProperty
    {
        public static bool IsAnyNullOrEmpty(object myObj)
        {
            foreach (PropertyInfo p in myObj.GetType().GetProperties())
            {
                if (p.Name.Equals("ID"))
                {
                    continue;
                }
                if (p.PropertyType == typeof(string))
                {
                    string value = (string)p.GetValue(myObj);
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
