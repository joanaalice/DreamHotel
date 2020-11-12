using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Auxiliar
{
    public static class CPFMask
    {
        public static string CPFMasked(string cpf)
        {
            cpf = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            return cpf;
        }
        public static string CPFUnmasked(string cpf)
        {
<<<<<<< HEAD
            cpf = cpf.Replace(".", "").Replace("-", "");
=======
            cpf = cpf.Replace(".","").Replace("-", "");
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
            return cpf;
        }
    }
}
