using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborator1.Domain;

namespace Laborator1.Domain
{
    internal class Cabinet: Entitate
    {
        private String tip_cabinet;
        public String Tip_cabinet { get { return tip_cabinet; } set { tip_cabinet = value; } }

       
        public Cabinet(int id_cabinet, string tip_cabinet)
        {
            this.Id = id_cabinet;
            Tip_cabinet = tip_cabinet;
        }
    }
}
