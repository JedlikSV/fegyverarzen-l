using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenál
{
    class Program
    {
        enum fegyverek {apaökle, uzi, m4, lángszóró, kézigránát, revolver, gépágyú, shotgun};
        static void Main(string[] args)
        {
            //fegyverek kezemben = fegyverek.kézigránát;         

            //fegyvertár.Insert(0, fegyverek.kézigránát);


            List<fegyverek> fegyvertár = new List<fegyverek>();
            //Egy fegyvert csak egy példányban tárolhatunk

            Felpakol(fegyvertár); //Az összes fegyvert berakja a fegyvertárba
            Listázó(fegyvertár);
            Kivesz(fegyvertár); //Egy fegyvert kivesz a fegyvertárból
            Listázó(fegyvertár);
            Felvesz(fegyvertár, ); //Egy fegyvert berak a tár végére
            Listázó(fegyvertár);
            Felvesz2(fegyvertár); //Egy fegyvert berak az i. helyre
            Listázó(fegyvertár);
            Kiürít(fegyvertár);
            Listázó(fegyvertár);
            int db = FegyverSzám(fegyvertár);
            Listázó(fegyvertár);     
          
            Console.ReadKey();
        }

        static void Felvesz(List<fegyverek> fegyvertár, fegyverek fegyver)
        {
            if (!fegyvertár.Contains(fegyver))
            {

            }
        }

        static int FegyverSzám(List<fegyverek> fegyvertár)
        {
            int dbszám = 0;
            for (int i = 0; i < fegyvertár.Count; i++)
            {
                dbszám++;
            }
            return dbszám;
        }

        static void Kiürít(List<fegyverek> fegyvertár)
        {
            fegyvertár.Clear();
        }

        static void Felvesz2(List<fegyverek> fegyvertár)
        {
            fegyvertár.Insert(0, fegyverek.kézigránát);
        }

        static void Kivesz(List<fegyverek> fegyvertár)
        {
            fegyvertár.Remove(fegyverek.uzi);
        }

        static void Listázó(List<fegyverek> fegyvertár)
        {
            foreach (fegyverek fegyver in fegyvertár)
            {
                Console.WriteLine(fegyver);
            }
        }

        static void Felpakol(List<fegyverek> fegyvertár)
        {
            fegyvertár.Add(fegyverek.apaökle);
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.m4);
            fegyvertár.Add(fegyverek.lángszóró); 
            fegyvertár.Add(fegyverek.kézigránát);
            fegyvertár.Add(fegyverek.revolver);
            fegyvertár.Add(fegyverek.gépágyú);
            fegyvertár.Add(fegyverek.shotgun);
        }
    }
}
