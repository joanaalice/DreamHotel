using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Checkers
{
    public static class CheckAttributeLength
    {
        public static List<String> AttributeLength<T>(Object myObj)
        {
            List<string> ErrorLength = new List<string>();
            Type objectType = myObj.GetType();
            foreach (var prop in objectType.GetProperties())
            {
                var fieldLength = ((LengthAttribute)prop.GetCustomAttribute(typeof(LengthAttribute)))?.FieldLength;
                var minFieldLength = ((MinLength)prop.GetCustomAttribute(typeof(MinLength)))?.MinFieldLength;

                var value = prop.GetValue(myObj)?.ToString();

                if (value != null && value.Length > fieldLength)
                {
                    ErrorLength.Add($"O numero máximo de caracteres do campo {prop.Name} é de {fieldLength}.");
                }
                else if (value != null && value.Length < minFieldLength)
                {
                    ErrorLength.Add($"O numero minimo de caracteres do campo {prop.Name} é de {minFieldLength}.");
                }
            }
            foreach (string item in ErrorLength)
            {
                Console.WriteLine(item);
            }
            return ErrorLength;
        }
    }
}
