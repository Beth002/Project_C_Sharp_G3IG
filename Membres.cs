using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GESTION_ADHESION_GROUP6
{
    class Membres
    {
        int id;
        string noms;
        string telephone;
        string sexe;
        string nationalite;
        string mail;
        string adresse;
        DateTime dateAdhesion;
        byte[] photo;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public string Nationalite
        {
            get
            {
                return nationalite;
            }

            set
            {
                nationalite = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public DateTime DateAdhesion
        {
            get
            {
                return dateAdhesion;
            }

            set
            {
                dateAdhesion = value;
            }
        }

        public byte[] Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }

        SqlConnection con;
        //Permettent la recherche dans la DataGrid
        SqlDataAdapter datatable = null;
        SqlDataReader dr = null;
        DataSet ds = null;
        public int AjouterMembre(Membres membre)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "insert into t_Membres(noms, telephone, sexe, nationalite, mail, adresse, dateAdhesion, photo) values (@noms, @telephone, @sexe, @nationalite, @mail, @adresse, @dateAdhesion, @photo)";
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id", membre.Id);
                SqlParameter prNoms = new SqlParameter("@noms", membre.Noms);
                SqlParameter prTelephone = new SqlParameter("@telephone", membre.Telephone);
                SqlParameter prSexe = new SqlParameter("@sexe", membre.Sexe);
                SqlParameter prNationalite = new SqlParameter("@nationalite", membre.Nationalite);
                SqlParameter prMail = new SqlParameter("@mail", membre.Mail);
                SqlParameter prAdresse = new SqlParameter("@adresse", membre.Adresse);
                SqlParameter prDateAdhesion = new SqlParameter("@dateAdhesion", membre.DateAdhesion);
                SqlParameter prPhotoMembre = new SqlParameter("@photo", membre.Photo);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prNoms);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prSexe);
                cmd.Parameters.Add(prNationalite);
                cmd.Parameters.Add(prMail);
                cmd.Parameters.Add(prAdresse);
                cmd.Parameters.Add(prDateAdhesion);
                cmd.Parameters.Add(prPhotoMembre);
                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }

        //public void EnvoyerWhatsApp()
        //{
        //    WhatsApp wa = new WhatsApp("+243821102385", "443-860", "Samuel MK", false, false);
        //    wa.Connect();
        //    string message = "Bonjour";
        //    string to = "+243974177011";
        //    wa.SendMessage(to, message);

        //    wa.Disconnect();
        //}
        //public void envoyer(Membres ms) {
        //    WhatsApp m = new WhatsApp(ms.Message, "","",true,true);
        //    m.Connect();
        //    IWhatsAppNETAPI send = new ne;
        //    if (send.IsConnected)
        //    {
        //        string message = "Bonjour, Vous etes maintenant enregistrer dans le groupe 6";
        //        string numero = "+243974177011";
        //        m.SendMessage();
        //        Console.WriteLine("Reussi");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Echec");
        //    }
        //}
        public List<Membres> getMembres()
        {
            //Definition de la liste des Mmebres
            List<Membres> list = new List<Membres>();

            //Pour lire les elements qu'il y a dans la table Mmebre : Liste de Mmebres
            con = new DataAccess().DBConnect();
            string strquery = "select id, noms, telephone, sexe, nationalite, mail, adresse, dateAdhesion from t_Membres";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Membres membre = new Membres();
                membre.Id = Convert.ToInt32(dr["id"].ToString());
                membre.Noms = dr["noms"].ToString();
                membre.Telephone = dr["telephone"].ToString();
                membre.Sexe = Convert.ToString(dr["sexe"].ToString());
                membre.Nationalite = dr["nationalite"].ToString();
                membre.Mail = dr["mail"].ToString();
                membre.Adresse = dr["adresse"].ToString();
                //membre.Imagelocation = dr["photoMembre"].ToString();
                membre.DateAdhesion = Convert.ToDateTime(dr["dateAdhesion"].ToString());
                list.Add(membre);
            }
            return list;
        }

        //public List<Membres> getSearch(string search)
        //{
        //    List<Membres> list = new List<Membres>();
        //    string strquery = "select * from t_Membres where Concat(id, noms) like'%" + search + "%'";
        //    SqlCommand cmd;
        //    if (DataAccess.)
        //    {
        //        cmd = new SqlCommand(strquery, DataAccess.Equals.con);
        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            Membres membre = new Membres();
        //            membre.Id = Convert.ToInt32(rd["id"]);
        //            membre.Noms = rd["noms"].ToString();
        //            membre.Telephone = rd["telephone"].ToString();
        //            membre.Sexe = rd["sexe"].ToString();
        //            membre.Nationalite = rd["nationalite"].ToString();
        //            membre.Mail = rd["mail"].ToString();
        //            membre.Adresse = rd["adresse"].ToString();
        //            membre.DateAdhesion = Convert.ToDateTime(rd["dateAdhesion"].ToString());
        //            list.Add(membre);
        //        }
        //    }

        //    return list;
        //}

            //Pour rechercher un Membre
        public DataTable Searching(string search)
        {
            SqlCommand cmd;
            con = new DataAccess().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("select * from t_Membres where noms like '%" + search + "%'", con);
            datatable = null;
            datatable = new SqlDataAdapter(cmd);
            ds = new DataSet();
            datatable.Fill(ds);
            con.Close();

            return ds.Tables[0];
        }

        public int ModifierMembre(Membres membre)
        {
            int value = 0;

            string strquery = "update t_Membres set noms = @noms, telephone = @telephone, sexe = @sexe, nationalite = @nationalite, mail = @mail, adresse = @adresse, dateAdhesion = @dateAdhesion where id = @id";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id", membre.Id);
                SqlParameter prNoms = new SqlParameter("@noms", membre.Noms);
                SqlParameter prTelephone = new SqlParameter("@telephone", membre.Telephone);
                SqlParameter prSexe = new SqlParameter("@sexe", membre.Sexe);
                SqlParameter prNationalite = new SqlParameter("@nationalite", membre.Nationalite);
                SqlParameter prMail = new SqlParameter("@mail", membre.Mail);
                SqlParameter prAdresse = new SqlParameter("@adresse", membre.Adresse);
                //SqlParameter prPhotoMembre = new SqlParameter("@photoMembre", membre.Imagelocation);
                SqlParameter prDateAdhesion = new SqlParameter("@dateAdhesion", membre.DateAdhesion);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prNoms);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prSexe);
                cmd.Parameters.Add(prNationalite);
                cmd.Parameters.Add(prMail);
                cmd.Parameters.Add(prAdresse);
                //cmd.Parameters.Add(prPhotoMembre);
                cmd.Parameters.Add(prDateAdhesion);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerMembre(string code)
        {
            int value = 0;

            string strquery = "delete t_Membres where id = @id";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    }
}
