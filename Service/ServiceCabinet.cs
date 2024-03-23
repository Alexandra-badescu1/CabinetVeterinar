using Laborator1.Domain;
using Laborator1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.Service
{
    internal class ServiceCabinet
    {
        RepositoryCabinet repositoryCabinet;
        RepositoryDoctor repositoryDoctor;

        public ServiceCabinet(RepositoryCabinet repositoryCabinet, RepositoryDoctor repositoryDoctor)
        {
            this.repositoryCabinet = repositoryCabinet;
            this.repositoryDoctor = repositoryDoctor;
        }

        public IEnumerable<Doctor> GetAllDoc()
        {
            return repositoryDoctor.GetAll();
        }
        public IEnumerable<Cabinet> GetAll()
        {
            return repositoryCabinet.GetAll();
        }
        public IEnumerable<Doctor> FilteredCabinet(int id)
        {
            IEnumerable<Doctor> doctors = repositoryDoctor.GetAll();
            HashSet<Doctor> doctors1 = new HashSet<Doctor>();
            foreach(var doc in doctors)
            {
                if (doc.Id_cabinet == id)
                {
                    doctors1.Add(doc);
                }
            }
            return doctors1;

        }

        public void AddDoctor(int id_doctor,String nume,String specializare,int id_cabinet)
        {
            Doctor doc = new Doctor(id_doctor, nume, specializare, id_cabinet);
            repositoryDoctor.Add(doc);
        }
        public void UpdateDoctor(int id_doctor, String nume, String specializare, int id_cabinet)
        {
            Doctor doc = new Doctor(id_doctor, nume, specializare, id_cabinet);
            repositoryDoctor.Update(doc);
        }
        public void deleteDoctor(int id)
        {
            repositoryDoctor.Delete(id);
        }
    }
}
