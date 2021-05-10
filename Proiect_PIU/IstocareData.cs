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
        Buget GetBuget(string _tip);

    }
}
