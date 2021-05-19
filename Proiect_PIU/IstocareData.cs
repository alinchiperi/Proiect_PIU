using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proiect_PIU
{
    public interface IstocareData
    {
        void AddBuget(Buget b);
        ArrayList GetBugetTotal();
        bool UpdateBuget(Buget BugetActualizat);
        Buget GetBuget(string tip, string provenienta);
        Buget GetBuget(string tip);
       ArrayList GetBugetTotal(string tip);
    }
}
