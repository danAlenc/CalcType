using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcType1
{
    internal class Processos
    {
        private String Numero1;
        private String Numero2;
        private String Result;

        public String getNumero1()
        {
            return Numero1;
        }

        public void setNumero1(String numero1)
        {
            Numero1 = numero1;
        }

        public String getNumero2()
        {
            return Numero2;
        }

        public void setNumero2(String numero2)
        {
            Numero2 = numero2;
        }

        public String getResult()
        {
            return Result;
        }

        public void setResult(String resultado)
        {
            Result = resultado;
        }

    }
}
