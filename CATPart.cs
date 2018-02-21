using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFITF; //CATIA V5 InfInterfaces Object Library

namespace Hello3DX
{
    class CATPart
    {
        private INFITF.Application catia;
        
        public void createPoint ()
        {
            Console.WriteLine("--> create point");

            catia = CATMain.catia;
            // How do I re-reference the CATIA object here?
        }
    }
}