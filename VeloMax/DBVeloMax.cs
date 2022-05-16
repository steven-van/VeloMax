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
           
            } catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return connection;
        }

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

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            MySqlConnection connection = GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            connection.Close();
        }
    }
}
