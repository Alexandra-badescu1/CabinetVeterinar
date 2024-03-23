using Laborator1.Domain;
using Laborator1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        ServiceCabinet cabinet1;
        int idCabinet = -1;
        int idDoctor = -1;
        public Form1()
        {
            InitializeComponent();
        }

        internal void SetService(ServiceCabinet cabinet)
        {
            cabinet1 = cabinet;  
        }
        public void ScrieDoctori()
        {
            cabinet_vetDataSet.doctor.Clear();   
             var doctors = cabinet1.FilteredCabinet(idCabinet);
             foreach (var doctor in doctors)
                cabinet_vetDataSet.doctor.AdddoctorRow(doctor.Id, doctor.Nume, doctor.Specializare, doctor.Id_cabinet);
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cabinet_vetDataSet.doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.cabinet_vetDataSet.doctor);
            // TODO: This line of code loads data into the 'cabinet_vetDataSet.cabinet' table. You can move, or remove it, as needed.
            this.cabinetTableAdapter.Fill(this.cabinet_vetDataSet.cabinet);

            // TODO: This line of code loads data into the 'cabinet_vetDataSet21.cabinet' table. You can move, or remove it, as needed.
            this.cabinetTableAdapter2.Fill(this.cabinet_vetDataSet21.cabinet);
            // TODO: This line of code loads data into the 'cabinet_vetDataSet21.doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter2.Fill(this.cabinet_vetDataSet21.doctor);
            // TODO: This line of code loads data into the 'cabinet_vetDataSet11.doctor' table. You can move, or remove it, as needed.
        
        }

        private void ButonAdaugare_Click(object sender, EventArgs e)
        {
            if(idCabinet == -1)
            {
                MessageBox.Show("Alegeti un cabinet", "EROARE");

            }
            else
            {
                try
                {

                    int idDoctor = Convert.ToInt32(TextIdDoctor.Text);
                    String nume = NumeDoctor.Text;
                    String specializare = SpecializareDoctor.Text;
                    if (nume.Length < 20)
                    {
                        nume = nume.PadRight(20);
                    }
                    else if (nume.Length > 20)
                    {
                        nume = nume.Substring(0, 20);
                    }
                    cabinet1.AddDoctor(idDoctor, nume, specializare, idCabinet);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "EROARE");
                }
                ScrieDoctori();
            }

            TextIdDoctor.Clear();
            NumeDoctor.Clear();
            SpecializareDoctor.Clear();
        }

        private void UpdateButton_Click(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(IdDoctorUpdate.Text);
            String nume =   NumeDoctorUpdate.Text;
            String specializare = FieldUpdate.Text;
            cabinet1.UpdateDoctor(id, nume, specializare, idCabinet);
            ScrieDoctori();
            IdDoctorUpdate.Clear();
            NumeDoctorUpdate.Clear();
            FieldUpdate.Clear();
            
        }

        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(IDDelete.Text);
            cabinet1.deleteDoctor(id);
            IDDelete.Clear();
            ScrieDoctori();
        }

        private void DataGridView3_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            idCabinet = int.Parse(dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
            ScrieDoctori();
        }

        private void ButtonRefesh(object sender, MouseEventArgs e)
        {

        }
    }
}
