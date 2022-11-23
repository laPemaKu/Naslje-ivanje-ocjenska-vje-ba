using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_Ocjenska_Vježba
{
    internal class Program
    {
        class Brojevi
        {
            public double broj;

            public Brojevi(double broj)
            {
                this.broj = broj;
            }

            public double Broj { get => broj; set => broj = value; }

            virtual public double ApsVrijednost()
            {
                return 0;
            }
        }
        class Cijeli : Brojevi
        {
            public Cijeli(double broj) : base(broj)
            {

            }
            public override double ApsVrijednost()
            {
                return this.broj;
            }
        }
        class Pozitivni : Cijeli
        {
            public Pozitivni(double broj) : base(broj)
            {

            }
            public override double ApsVrijednost()
            {
                return this.broj;
            }
        }
        class Negativni : Cijeli
        {
            public Negativni(double broj) : base(broj)
            {

            }
            public override double ApsVrijednost()
            {
                return this.broj;
            }
        }
        class Decimalni : Brojevi
        {
            public Decimalni(double broj) : base(broj)
            {

            }
            public override double ApsVrijednost()
            {
                return this.broj;
            }
        }
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni(100);
            Negativni y = new Negativni(-100);
            Decimalni z = new Decimalni(100.45);

            Console.WriteLine("Apsolutna vrijednost x je: ");
            Console.WriteLine(x.ApsVrijednost());
            Console.WriteLine("Apsolutna vrijednost y je: ");
            Console.WriteLine(y.ApsVrijednost());
            Console.WriteLine("Apsolutna vrijednost z je: ");
            Console.WriteLine(z.ApsVrijednost());

            Console.ReadKey();
        }
    }
}
