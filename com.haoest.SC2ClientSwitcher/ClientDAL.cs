using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace com.haoest.SC2ClientSwitcher
{
    public class ClientDAL
    {
        public static bool CreateClient(Client client)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=settings.db;");
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO clientlist(region, locale, name, gamefolder) VALUES(@region, @locale, @name, @gamefolder)";
                cmd.Parameters.Add(new SQLiteParameter("region", client.Region));
                cmd.Parameters.Add(new SQLiteParameter("locale", client.Locale));
                cmd.Parameters.Add(new SQLiteParameter("name", client.Name));
                cmd.Parameters.Add(new SQLiteParameter("gamefolder", client.GameFolder));

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i == 1;
            }
            catch (SQLiteException se)
            {
                MessageBox.Show(se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data);
                return false;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace + "\n\n" + ae.Data);
                return false;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message + "\n\n" + ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.Data);
                return false;
            }
        }

        public static bool UpdateClient(Client client, String locale)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=settings.db;");
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE clientlist SET region=@region, name=@name, gamefolder=@gamefolder, locale=@locale WHERE locale=@original_locale";
                cmd.Parameters.Add(new SQLiteParameter("region", client.Region));
                cmd.Parameters.Add(new SQLiteParameter("name", client.Name));
                cmd.Parameters.Add(new SQLiteParameter("locale", client.Locale));
                cmd.Parameters.Add(new SQLiteParameter("gamefolder", client.GameFolder));
                cmd.Parameters.Add(new SQLiteParameter("original_locale", locale));
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i == 1;
            }
            catch (SQLiteException se)
            {
                MessageBox.Show(se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data);
                return false;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool DeleteClient(String locale)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=settings.db;");
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM clientlist where locale=@locale;";
                cmd.Parameters.Add(new SQLiteParameter("locale", locale));
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i == 1;
            }
            catch (SQLiteException se)
            {
                MessageBox.Show(se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data);
                return false;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DataTable GetAllClient()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source =" + System.Windows.Forms.Application.StartupPath + "\\settings.db;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "SELECT * FROM clientlist";
                cmd.CommandType = CommandType.Text;
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
                else
                {
                    //throw new NullReferenceException("No Record Available.");  
                }

                dr.Close();
                conn.Close();

            }
            catch (SQLiteException se)
            {
                MessageBox.Show(se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static String[] GetClientDataReader(String locale)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=settings.db;");
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM clientlist WHERE locale=@locale;";
                cmd.Parameters.Add(new SQLiteParameter("locale", locale));
                SQLiteDataReader dr = cmd.ExecuteReader();
                String[] clientStr = null;
                if (dr.Read())
                {
                    clientStr = new String[] { dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3) };
                }
                conn.Close();
                return clientStr;
            }
            catch (SQLiteException se)
            {
                MessageBox.Show(se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data);
                return null;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message + " \n\n" + ex.Source + "\n\n" + ex.StackTrace);
                return null;
            }
        }
    }
}
