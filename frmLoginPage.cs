using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_ADHESION_GROUP6
{
    public partial class frmLoginPage : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public frmLoginPage()
        {
            InitializeComponent();
            con.ConnectionString = string.Format("Server = DESKTOP-IA6R4T3; Database = dbAdhesion; User Id = sa; Password = dddd;");
        }

        //La Methode pour actualiser les champs du LOGIN PAGE
        private void Actualiser()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        //La Methode qui permet de se connecter
        private void SeConnecter()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from t_User";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                try
                {
                    if (txtUsername.Text.Equals(dr["noms"].ToString()) && txtPassword.Text.Equals(dr["motdepasse"].ToString()))
                    {
                        frmAdhesion adhesion = new frmAdhesion();
                        frmLoginPage access = new frmLoginPage();
                        this.Hide();
                        adhesion.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0x25CF;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            SeConnecter();
        }
    }
}
