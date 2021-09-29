using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Class1
    {
        public static void Metodo()
        {
            try
            {
                int num1 = 4;
                int num2 =0;
                if(num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                int var = num1 / num2;

            }
            catch (DivideByZeroException e)
            {
                throw new MiExcepcion("Catapumbas", e);
            }
            
            catch (Exception)
            {
                throw;
            }

        }
        

    }
}
