using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
      private int Base;
        private int altezza;
        private  int Area;
            private  int Perimetro;
        public Rettangolo(int Base, int altezza) //costruttore
        {
            this.Base = Base;
            this.altezza = altezza;
        }

       

    public int CalcoloArea(int Base, int altezza)
    {
        int Area = Base * altezza;
        return Area;
    }
    public int CalcoloPerimetro(int Base, int altezza)
    {
        int Perimetro = 2 * Base + 2 * altezza;
        return Perimetro;
    }

    public void StampaRettangolo(  )
    {
         
        Console.WriteLine("----- Rettangolo -------");
        Console.WriteLine("AREA: " + Area);
        Console.WriteLine("PERIMETRO: " + Perimetro);
        Console.WriteLine("------------------");

        }

    }
}


