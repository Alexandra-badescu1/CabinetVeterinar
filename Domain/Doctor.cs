using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.Domain
{
    internal class Doctor : Entitate
    {
        private String nume;
        private String specializare;
        private int id_cabinet;

        public String Nume { get{ return nume; } set { nume = value; } }
        public String Specializare { get { return specializare; } set { specializare = value; } }
        public int Id_cabinet { get { return id_cabinet; } set { id_cabinet = value; } }
        
        public Doctor(int id_doctor,String Nume,String Specializare, int id_cabinet)
        {
            this.Id = id_doctor;
            this.Nume = Nume;
            this.Specializare = Specializare;
            this.Id_cabinet = id_cabinet;
        }
    }
}
