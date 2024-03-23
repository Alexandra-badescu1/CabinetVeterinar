using Laborator1.Repository;
using Laborator1.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
           
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server=ALLEN-WALKER\SQLEXPRESS01;
                                        Database=cabinet_vet;Integrated Security=true;TrustServerCertificate=true;")) //distruge obiectele cand nu mai folosim blocul using
                {
                    connection.Open();
                    RepositoryCabinet repositoryCabinet = new RepositoryCabinet(connection);
                    RepositoryDoctor repositoryDoctor = new RepositoryDoctor(connection);
                    ServiceCabinet cabinet = new ServiceCabinet(repositoryCabinet,repositoryDoctor);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form1 form = new Form1();
                    form.SetService(cabinet);
                    MessageBox.Show("Starea Conexiunii: " + Convert.ToString(connection.State));
                    Application.Run(form);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        }
    }

