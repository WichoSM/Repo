using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_Comida
{ 
    class Servicio
    {
        int g, gp;
        int p, h, re, res, resT;

        int hamburguesa = 0, papitas = 0;
        // H = 30 , P = 20

        public void ventaHam()
        {
            setHam(hamburguesa + 1);
        }

        public void setHam(int x)
        {
            hamburguesa = x;
        }

        public int getHam()
        {
            return hamburguesa;
        }

        //Papitas

        public void ventaPap()
        {
            setPap(papitas + 1);
        }

        public void setPap(int y)
        {
            papitas = y;
        }

        public int getPap()
        {
            return papitas;
        }
        
        public int VentaHamburguesas()
        {
            re = getHam() * 30;
            return re;
        }

        public int VentaPapitas()
        {
            res = getPap() * 20;
            return res;
        }

        public int ventaTotal()
        {
            resT = VentaHamburguesas() + VentaPapitas();
            return resT;
        }

    }
}
