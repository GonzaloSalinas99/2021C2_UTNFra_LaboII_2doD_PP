using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCiberCafe
{
    class Computadora
    {
        private string identificador;
        private List<string> software;
        private List<string> hadware;
        private List<string> perifericos;
        private List<string> juegos;

        public Computadora()
        {
            this.hadware = new List<string>();
            this.software = new List<string>();
            this.juegos = new List<string>();
            this.perifericos = new List<string>();
        }

        public Computadora(string identificador):this()
        {
            this.identificador = identificador;
        }



    }
}
