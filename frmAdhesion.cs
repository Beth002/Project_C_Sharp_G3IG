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
using WhatsAppApi;
using WhatsAppNETAPI;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Net;
using System.IO;

namespace GESTION_ADHESION_GROUP6
{
    public partial class frmAdhesion : Form
    {
        Membres membre = new Membres();

        //Envoie de Message WhatsApp
        private void WhatsApp()
        {
            try
            {
                TwilioClient.Init(
                    Environment.GetEnvironmentVariable("ACeed96b6816a9d0953fa6a559b067ab72"),
                    Environment.GetEnvironmentVariable("9beadfe8564a4b3a48aa70b20d70fb03")
                    );

                var message = MessageResource.Create(
                    from: new PhoneNumber("whatsapp:+14155238886"),
                    to: new PhoneNumber("whatsapp:+243974177011"),
                    body: "Bonjour cher(e) membre, votre adhésion dans le GROUPE 6 s'est effectuée avec succès."
                    );

                MessageBox.Show("Message SID: " + message.Sid, "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message non envoye", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SendWhatsApp()
        //{
        //    try
        //    {
        //        const string accountSid = "ACeed96b6816a9d0953fa6a559b067ab72";
        //        const string authToken = "9beadfe8564a4b3a48aa70b20d70fb03";
        //        TwilioClient.Init(accountSid, authToken);
        //        var mediaUrl = new[]
        //        {
        //            new Uri ("Media Url")
        //        }.ToList();

        //        var message = MessageResource.Create(mediaUrl: mediaUrl, from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"), body: "Profile", to: new Twilio.Types.PhoneNumber("whatsapp:" + txtPhone.Text));
        //        MessageBox.Show(message.Sid);
        //        //var messageOptions = new CreateMessageOptions(
        //        //new PhoneNumber("whatsapp:" + txtPhone.Text));
        //        //messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
        //        //messageOptions.Body = "Bonjour cher(e) membre, votre adhésion dans le GROUPE 6 s'est effectuée avec succès.";


        //        //var message = MessageResource.Create(messageOptions);
        //        //MessageBox.Show(message.Body);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Message non envoye", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void SendWhatsMessage()
        //{
            
        //        var url = "https://api.trillio.com/whatsapp/send";
        //        var request = (HttpWebRequest)WebRequest.Create(url);
        //        request.Method = "POST";

        //        var message = "Bonjour cher(e) membre, votre adhésion dans le GROUPE 6 s'est effectuée avec succès.";
        //        var phoneNumber = "+243974177011";

        //        var postData = "{\"to\":\"" + phoneNumber + "\",\"message\":\"" + message + "\"}";
        //        var data = System.Text.Encoding.UTF8.GetBytes(postData);

        //        request.ContentType = "application/json";
        //        request.ContentLength = data.Length;

        //        request.Headers["Authorization"] = "Bearer <9beadfe8564a4b3a48aa70b20d70fb03>";

        //        using (var stream = request.GetRequestStream())
        //        {
        //            stream.Write(data, 0, data.Length);
        //        }
        //        var reponse = (HttpWebResponse)request.GetResponse();
        //        var reponseString = new StreamReader(reponse.GetResponseStream()).ReadToEnd();

        //        MessageBox.Show(reponseString);
            
        //    //catch(Exception ex)
        //    //{
        //    //    MessageBox.Show("Message non envoye", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}
        //}
        
        //Notre BindingClass pour Ajout des Membres
        private void BindingClassAdd()
        {
            membre.Noms = txtNoms.Text;
            membre.Telephone = txtPhone.Text;
            membre.Sexe = Convert.ToString(cbSexe.SelectedItem);
            membre.Nationalite = txtNationalite.Text;
            membre.Mail = txtMail.Text;
            membre.Adresse = txtAdresse.Text;
            //membre.Imagelocation = pbPhoto.
            membre.DateAdhesion = Convert.ToDateTime(DateAdhesion.Text);
            Image img = pbPhoto.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            membre.Photo = arr;
            ByteConverter cin = new ByteConverter();
        }

        //Notre BindingClass pour mise à jour des Membres
        private void BindingClassUpdate()
        {
            membre.Id = Convert.ToInt32(txtId.Text);
            membre.Noms = txtNoms.Text;
            membre.Telephone = txtPhone.Text;
            membre.Sexe = Convert.ToString(cbSexe.SelectedItem);
            membre.Nationalite = txtNationalite.Text;
            membre.Mail = txtMail.Text;
            membre.Adresse = txtAdresse.Text;
            //membre.Imagelocation = pbPhoto.
            membre.DateAdhesion = Convert.ToDateTime(DateAdhesion.Text);
        }

        private void RefreshListMembres()
        {
            lbCode.Text = "";
            lbNoms.Text = "";
            lbPhone.Text = "";
            lbSexe.Text = "";
            lbNationalite.Text = "";
            lbMail.Text = "";
            lbAdresse.Text = "";
            lbDate.Text = "";
            lbDateNow.Text = "";
        }
        public frmAdhesion()
        {
            InitializeComponent();
        }

        //private void whats(string numero, string message)
        //{
        //   IWhatsAppNETAPI n = new IWhatsAppNETAPI("","","",true,true);
        //}

        //La Methode pour envoyer le Message WhatsApp
        //private void sendWhatsApp(string numero, string message)
        //{
        //    try
        //    {
        //        if (numero == "")
        //        {
        //            MessageBox.Show("Aucun numero entrer");
        //        }
        //        if (numero.Length <= 0)
        //        {
        //            numero = "+243" + numero;
        //        }
        //        numero = numero.Replace(" ", "");
        //        System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + numero + "&text" + message);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void WhatsAppMSG()
        //{
        //    string from = "+243974177011";
        //    string to = txtPhone.Text;
        //    //string message = txtMessage.Text;

        //    WhatsApp wa = new WhatsApp(from, "https://wa.me/c/243974177011", "El-Bethel", false, false);

        //    wa.OnConnectSuccess += () =>
        //    {
        //        MessageBox.Show("Connecter a WhatsApp...");
        //        wa.OnLoginSuccess += (phoneNumber, data) =>
        //        {
        //            //wa.SendMessage(to, message);
        //            MessageBox.Show("Message envoye");
        //        };
        //        wa.OnLoginFailed += (data) =>
        //        {
        //            MessageBox.Show("Echec de connexion : (0)", data);
        //        };
        //        wa.Login();
        //    };

        //    wa.OnConnectFailed += (ex) =>
        //    {
        //        MessageBox.Show("Connexion echouee");
        //    };
        //    wa.Connect();
        //}
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //sendWhatsApp(txtPhone.Text, txtMessage.Text);

            BindingClassAdd();

            int value = membre.AjouterMembre(membre);

            if (value >= 1)
            {
                MessageBox.Show("Enregistrement Réussi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();
            }
            else
            {
                MessageBox.Show("Enregistrement Echoué", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            LoadList();
            Refresh();
            WhatsApp();
            //SendWhatsMessage();
            //SendWhatsApp();
            //WhatsAppMSG();
            //envoyer();
            //membre.EnvoyerWhatsApp();
            btnAjouter.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnActualiser.Enabled = true;
            clearTextbox();
        }

        public void clearTextbox()
        {
            //txtMessage.Text = "";
            txtPhone.Text = "";
        }

        private void LoadList()
        {
            try
            {
                //Charger DataGrid
                dgMembres.DataSource = membre.getMembres();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de chargement", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            String imagelocation = " ";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pbPhoto.ImageLocation = imagelocation;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Echec lors de l'importation de l'image", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdhesion_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            BindingClassUpdate();

            int value = membre.ModifierMembre(membre);
            if (value >= 1)
            {
                MessageBox.Show("Membre modifié avec succès", "SUCCES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();
            }
            else
            {
                MessageBox.Show("Membre non modifié", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int value = membre.SupprimerMembre(txtId.Text);
            if (value >= 1)
            {
                MessageBox.Show("Membre supprimé avec succès", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Membre non supprimé", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadList();
            btnAjouter.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = true;
        }

        private void Refresh()
        {
            txtId.Text = "";
            txtNoms.Text = "";
            txtPhone.Text = "";
            cbSexe.Text = "";
            txtNationalite.Text = "";
            txtMail.Text = "";
            txtAdresse.Text = "";
            DateAdhesion.Text = "";
            pbPhoto.Image = null;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            Refresh();
            RefreshListMembres();
            btnAjouter.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void dgMembres_DoubleClick(object sender, EventArgs e)
        {
            if (dgMembres.RowCount > 0)
            {
                txtId.Text = dgMembres["dgid", dgMembres.CurrentRow.Index].Value.ToString();
                txtNoms.Text = dgMembres["dgnoms", dgMembres.CurrentRow.Index].Value.ToString();
                txtPhone.Text = dgMembres["dgphone", dgMembres.CurrentRow.Index].Value.ToString();
                cbSexe.Text = dgMembres["dgsexe", dgMembres.CurrentRow.Index].Value.ToString();
                txtNationalite.Text = dgMembres["dgnationalite", dgMembres.CurrentRow.Index].Value.ToString();
                txtMail.Text = dgMembres["dgmail", dgMembres.CurrentRow.Index].Value.ToString();
                txtAdresse.Text = dgMembres["dgadresse", dgMembres.CurrentRow.Index].Value.ToString();
                DateAdhesion.Text = dgMembres["dgdate", dgMembres.CurrentRow.Index].Value.ToString();
                //pbPhoto.Image = dgMembres["dgphoto", dgMembres.CurrentRow.Index].Value.ToString();

                //Afficher le Membres adherer dans la liste
                lbCode.Text = txtId.Text;
                lbNoms.Text = txtNoms.Text;
                lbPhone.Text = txtPhone.Text;
                lbSexe.Text = cbSexe.Text;
                lbNationalite.Text = txtNationalite.Text;
                lbMail.Text = txtMail.Text;
                lbAdresse.Text = txtAdresse.Text;
                lbDate.Text = DateAdhesion.Text;
                lbDateNow.Text = Convert.ToString(DateTime.Now);

                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjouter.Enabled = false;
            }
        }

        private void frmAdhesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Voulez-vous vraiment quitter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                e.Cancel = true;
            frmLoginPage login = new frmLoginPage();
            frmAdhesion ad = new frmAdhesion();
            this.Hide();
            login.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgMembres.DataSource = membre.Searching(txtSearch.Text);
        }
    }
}
