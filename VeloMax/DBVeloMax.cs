using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VeloMax
{
    class DBVeloMax
    {
        public static MySqlConnection GetDBConnection()
        {
            String connString = "Server=localhost;Database=velomax;port=3306;User Id=root;password=root";
            MySqlConnection connection = new MySqlConnection(connString);
            try
            {
                connection.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return connection;
        }

        #region Fournisseur

        public static void AddFournisseur(string siret, string nom, string contact, string adresse, string libelle)
        {
            string query = "INSERT INTO Fournisseur (siret, nom, contact, adresse, libelle) VALUES (@SIRET, @NOM, @CONTACT, @ADRESSE, @LIBELLE);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SIRET", MySqlDbType.VarChar).Value = siret;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact;
            cmd.Parameters.Add("@ADRESSE", MySqlDbType.VarChar).Value = adresse;
            cmd.Parameters.Add("@LIBELLE", MySqlDbType.Enum).Value = libelle;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseur ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le fournisseur n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        public static void DeleteFournisseur(string siret)
        {
            string query = "DELETE FROM Fournisseur WHERE siret = @SIRET";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SIRET", MySqlDbType.VarChar).Value = siret;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseur supprimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le fournisseur n'a pas été supprimé \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateFournisseur(string siret, string nom, string contact, string adresse, string libelle)
        {
            string query = "UPDATE Fournisseur SET nom = @NOM, contact = @CONTACT, adresse = @ADRESSE, libelle = @LIBELLE WHERE siret = @siret;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SIRET", MySqlDbType.VarChar).Value = siret;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact;
            cmd.Parameters.Add("@ADRESSE", MySqlDbType.VarChar).Value = adresse;
            cmd.Parameters.Add("@LIBELLE", MySqlDbType.Enum).Value = libelle;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseur mis à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le fournisseur n'a pas été mis à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        #endregion

        #region Piece

        public static void AddPiece(string description, string categorie, double prixU, int stock, DateTime dateI, DateTime dateD, int delaiA)
        {
            string query = "INSERT INTO Piece (description, categorie, prixU, stock, dateI, dateD, delaiA) VALUES (@DESCRIPTION, @CATEGORIE, @PRIXU, @STOCK, @DATEI, @DATED, @DELAIA);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = description;
            cmd.Parameters.Add("@CATEGORIE", MySqlDbType.Enum).Value = categorie;
            cmd.Parameters.Add("@PRIXU", MySqlDbType.Decimal).Value = prixU;
            cmd.Parameters.Add("@STOCK", MySqlDbType.Int32).Value = stock;
            cmd.Parameters.Add("@DATEI", MySqlDbType.Date).Value = dateI;
            cmd.Parameters.Add("@DATED", MySqlDbType.Date).Value = dateD;
            cmd.Parameters.Add("@DELAIA", MySqlDbType.Int32).Value = delaiA;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pièce ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la pièce n'a pas été ajoutée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        public static void DeletePiece(int idPiece)
        {
            string query = "DELETE FROM Piece WHERE idPiece = @IDPIECE";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDPIECE", MySqlDbType.Int32).Value = idPiece;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pièce supprimée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la pièce n'a pas été supprimée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdatePiece(int idPiece, string description, string categorie, double prixU, int stock, DateTime dateI, DateTime dateD, int delaiA)
        {
            string query = "UPDATE Piece SET description = @DESCRIPTION, categorie = @CATEGORIE, prixU = @PRIXU, stock = @STOCK, dateI = @DATEI, dateD = @DATED, delaiA = @DELAIA WHERE idPiece = @IDPIECE;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDPIECE", MySqlDbType.Int32).Value = idPiece;
            cmd.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = description;
            cmd.Parameters.Add("@CATEGORIE", MySqlDbType.Enum).Value = categorie;
            cmd.Parameters.Add("@PRIXU", MySqlDbType.Decimal).Value = prixU;
            cmd.Parameters.Add("@STOCK", MySqlDbType.Int32).Value = stock;
            cmd.Parameters.Add("@DATEI", MySqlDbType.Date).Value = dateI;
            cmd.Parameters.Add("@DATED", MySqlDbType.Date).Value = dateD;
            cmd.Parameters.Add("@DELAIA", MySqlDbType.Int32).Value = delaiA;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pièce mise à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la pièce n'a pas été mise à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        #endregion

        #region Modele

        public static void AddModele(string nom, string grandeur, double prixU, string ligneP, DateTime dateI, DateTime dateD, int stock)
        {
            string query = "INSERT INTO Modele (nom, grandeur, prixU, ligneP, dateI, dateD, stock) VALUES (@NOM, @GRANDEUR, @PRIXU, @LIGNEP, @DATEI, @DATED, @STOCK);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@GRANDEUR", MySqlDbType.VarChar).Value = grandeur;
            cmd.Parameters.Add("@PRIXU", MySqlDbType.Decimal).Value = prixU;
            cmd.Parameters.Add("@LIGNEP", MySqlDbType.VarChar).Value = ligneP;
            cmd.Parameters.Add("@DATEI", MySqlDbType.Date).Value = dateI;
            cmd.Parameters.Add("@DATED", MySqlDbType.Date).Value = dateD;
            cmd.Parameters.Add("@STOCK", MySqlDbType.Int32).Value = stock;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modèle ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le modèle n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        public static void DeleteModele(int idModele)
        {
            string query = "DELETE FROM Modele WHERE idModele = @IDMODELE";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDMODELE", MySqlDbType.Int32).Value = idModele;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modèle supprimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le modèle n'a pas été supprimé \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateModele(int idModele, string nom, string grandeur, double prixU, string ligneP, DateTime dateI, DateTime dateD, int stock)
        {
            string query = "UPDATE Modele SET nom = @NOM, grandeur = @GRANDEUR, prixU = @PRIXU, ligneP = @LIGNEP, dateI = @DATEI, dateD = @DATED, stock = @STOCK WHERE idModele = @IDMODELE;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDMODELE", MySqlDbType.Int32).Value = idModele;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@GRANDEUR", MySqlDbType.VarChar).Value = grandeur;
            cmd.Parameters.Add("@PRIXU", MySqlDbType.Decimal).Value = prixU;
            cmd.Parameters.Add("@LIGNEP", MySqlDbType.VarChar).Value = ligneP;
            cmd.Parameters.Add("@DATEI", MySqlDbType.Date).Value = dateI;
            cmd.Parameters.Add("@DATED", MySqlDbType.Date).Value = dateD;
            cmd.Parameters.Add("@STOCK", MySqlDbType.Int32).Value = stock;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modèle mis à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le modèle n'a pas été mis à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        #endregion

        #region Client

        public static void AddClient(string type, string adresse, string courriel, string telephone)
        {
            string query = "INSERT INTO Client (type, adresse, courriel, telephone) VALUES (@TYPE, @ADRESSE, @COURRIEL, @TELEPHONE);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TYPE", MySqlDbType.Enum).Value = type;
            cmd.Parameters.Add("@ADRESSE", MySqlDbType.VarChar).Value = adresse;
            cmd.Parameters.Add("@COURRIEL", MySqlDbType.VarChar).Value = courriel;
            cmd.Parameters.Add("@TELEPHONE", MySqlDbType.VarChar).Value = telephone;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le client n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddClientIndividu(int idClient, string nom, string prenom)
        {
            string query = "INSERT INTO Individu (idClient, nom, prenom) VALUES (@IDCLIENT, @NOM, @PRENOM);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@PRENOM", MySqlDbType.VarChar).Value = prenom;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Individu ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Particulier ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, l'individu n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Erreur, le particulier n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddClientBoutique(int idClient, string nom, string contact, int remise, int volumeA)
        {
            string query = "INSERT INTO Boutique (idClient, nom, contact, remise, volumeA) VALUES (@IDCLIENT, @NOM, @CONTACT, @REMISE, @VOLUMEA);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact;
            cmd.Parameters.Add("@REMISE", MySqlDbType.Int32).Value = remise;
            cmd.Parameters.Add("@VOLUMEA", MySqlDbType.Int32).Value = volumeA;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Boutique ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la boutique n'a pas été ajoutée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }


        public static void DeleteClient(int idClient)
        {
            string query = "DELETE FROM Client WHERE idClient = @IDCLIENT";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client supprimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le client n'a pas été supprimé \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }


        public static void UpdateClient(int idClient, string type, string adresse, string courriel, string telephone)
        {
            string query = "UPDATE Client SET type = @TYPE, adresse = @ADRESSE, courriel = @COURRIEL, telephone = @TELEPHONE WHERE idClient = @IDCLIENT;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@TYPE", MySqlDbType.Enum).Value = type;
            cmd.Parameters.Add("@ADRESSE", MySqlDbType.VarChar).Value = adresse;
            cmd.Parameters.Add("@COURRIEL", MySqlDbType.VarChar).Value = courriel;
            cmd.Parameters.Add("@TELEPHONE", MySqlDbType.VarChar).Value = telephone;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client mis à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le client n'a pas été mis à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateClientIndividu(int idClient, string nom, string prenom)
        {
            string query = "UPDATE Individu SET nom = @NOM, prenom = @PRENOM WHERE idClient = @IDCLIENT;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@PRENOM", MySqlDbType.VarChar).Value = prenom;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Particulier mis à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le particulier n'a pas été mis à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateClientBoutique(int idClient, string nom, string contact, int remise, int volumeA)
        {
            string query = "UPDATE Boutique SET nom = @NOM, contact = @CONTACT, remise = @REMISE, volumeA = @VOLUMEA WHERE idClient = @IDCLIENT;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@NOM", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact;
            cmd.Parameters.Add("@REMISE", MySqlDbType.Int32).Value = remise;
            cmd.Parameters.Add("@VOLUMEA", MySqlDbType.Int32).Value = volumeA;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Boutique mise à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la boutique n'a pas été mise à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }



        #endregion

        #region Adhesion

        public static void AddAdhesion(int idClient, int idFidelite, DateTime dateAdhesion)
        {
            string query = "INSERT INTO Adhesion (idClient, idFidelite, dateAdhesion) VALUES (@IDCLIENT, @IDFIDELITE, @DATEADHESION);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@IDFIDELITE", MySqlDbType.Int32).Value = idFidelite;
            cmd.Parameters.Add("@DATEADHESION", MySqlDbType.Date).Value = dateAdhesion;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Particulier ajouté au Programme Fidelio avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, le particulier n'a pas été ajouté au Programme Fidelio \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteAdhesion(int idClient, int idFidelite)
        {
            string query = "DELETE FROM Adhesion WHERE idClient = @IDCLIENT AND idFidelite = @IDFIDELITE";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            cmd.Parameters.Add("@IDFIDELITE", MySqlDbType.Int32).Value = idFidelite;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adhésion supprimée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, l'adhésion n'a pas été supprimée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        //public static void UpdateAdhesion(int idClient, int idFidelite, DateTime dateAdhesion)
        //{
        //    string query = "UPDATE Adhesion SET dateAdhesion = @DATEADHESION WHERE idClient = @IDCLIENT, idFidelite = @IDFIDELITE;";
        //    MySqlConnection connection = GetDBConnection();
        //    MySqlCommand cmd = new MySqlCommand(query, connection);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
        //    cmd.Parameters.Add("@IDFIDELITE", MySqlDbType.Int32).Value = idFidelite;
        //    cmd.Parameters.Add("@DATEADHESION", MySqlDbType.Date).Value = dateAdhesion;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Adhésion mise à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Erreur, l'adhésion n'a pas été mise à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    connection.Close();

        //}

        #endregion

        #region Commande

        public static void AddCommande(DateTime dateC, string adresseL, DateTime dateL, int idClient)
        {
            string query = "INSERT INTO Commande (dateC, adresseL, dateL, idClient) VALUES (@DATEC, @ADRESSEL, @DATEL, @IDCLIENT);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DATEC", MySqlDbType.Date).Value = dateC;
            cmd.Parameters.Add("@ADRESSEL", MySqlDbType.VarChar).Value = adresseL;
            cmd.Parameters.Add("@DATEL", MySqlDbType.Date).Value = dateL;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la commande n'a pas été ajoutée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        public static void DeleteCommande(int idCommande)
        {
            string query = "DELETE FROM Commande WHERE idCommande = @IDCOMMANDE";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCOMMANDE", MySqlDbType.Int32).Value = idCommande;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande supprimée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la commande n'a pas été supprimée \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateCommande(int idCommande, DateTime dateC, string adresseL, DateTime dateL, int idClient)
        {
            string query = "UPDATE Commande SET dateC = @DATEC, adresseL = @ADRESSEL, dateL = @DATEL, idClient = @IDCLIENT WHERE idCommande = @IDCOMMANDE;";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCOMMANDE", MySqlDbType.Int32).Value = idCommande;
            cmd.Parameters.Add("@DATEC", MySqlDbType.Date).Value = dateC;
            cmd.Parameters.Add("@ADRESSEL", MySqlDbType.VarChar).Value = adresseL;
            cmd.Parameters.Add("@DATEL", MySqlDbType.Date).Value = dateL;
            cmd.Parameters.Add("@IDCLIENT", MySqlDbType.Int32).Value = idClient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande mise à jour avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, la commande n'a pas été mise à jour \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        #endregion

        #region Achat_piece

        public static void AddAchat_piece(int idCommande, int idPiece, int quantite)
        {
            string query = "INSERT INTO Achat_piece (idCommande, idPiece, quantite) VALUES (@IDCOMMANDE, @IDPIECE, @QUANTITE);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCOMMANDE", MySqlDbType.Int32).Value = idCommande;
            cmd.Parameters.Add("@IDPIECE", MySqlDbType.Int32).Value = idPiece;
            cmd.Parameters.Add("@QUANTITE", MySqlDbType.Int32).Value = quantite;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Achat de la pièce ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, l'achat de la pièce n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        #endregion


        #region Achat_modele

        public static void AddAchat_modele(int idCommande, int idModele, int quantite)
        {
            string query = "INSERT INTO Achat_modele (idCommande, idModele, quantite) VALUES (@IDCOMMANDE, @IDMODELE, @QUANTITE);";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDCOMMANDE", MySqlDbType.Int32).Value = idCommande;
            cmd.Parameters.Add("@IDMODELE", MySqlDbType.Int32).Value = idModele;
            cmd.Parameters.Add("@QUANTITE", MySqlDbType.Int32).Value = quantite;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Achat du modèle ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur, l'achat du modèle n'a pas été ajouté \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        #endregion

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            try
            {
                MySqlConnection connection = GetDBConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                connection.Close();
            } catch (MySql.Data.MySqlClient.MySqlException)
            {
                // Preventing bad entries
            }

        }

        public static int LastInsertedId()
        {
            int id = -1;
            string query = "SELECT LAST_INSERT_ID();";
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            try
            {
                id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur, l'id n'a pas pu être récupéré \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return id;

        }

        public static void PopulateComboBox(string query, ComboBox cb, int nbCols)
        {
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string s = "";
                    for(int i = 0; i < nbCols; i++)
                    {
                        if(i == nbCols - 1)
                        {
                            s += reader.GetString(i);
                        }
                        else
                        {
                            s += reader.GetString(i) + " - ";
                        }
                    }
                    cb.Items.Add(s);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
