using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace com.haoest.SC2ClientSwitcher
{
    public class Client
    {
        private String region;
        private String locale;
        private String gameFolder;
        private String name;

        public Client()
        {

        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Region
        {
            get { return region; }
            set { region = value; }
        }

        public String Locale
        {
            get { return locale; }
            set { locale = value; }
        }

        public String GameFolder
        {
            get { return gameFolder; }
            set { gameFolder = value; }
        }

        public Client(String clientText, String gameFolder)
        {
            this.region = GetRegionFromClientListItem(clientText);
            this.locale = GetLocaleFromClientListItem(clientText);
            this.name = GetNameFromClientListItem(clientText);
            this.gameFolder = gameFolder;
        }

        public static string GetLocaleFromClientListItem(string item)
        {
            return Regex.Split(item, " - ")[2];
        }

        public static string GetRegionFromClientListItem(string item)
        {
            return Regex.Split(item, " - ")[0];
        }

        public static string GetNameFromClientListItem(string item)
        {
            return Regex.Split(item, " - ")[1];
        }

        public static bool IsExsit(String item)
        {
            if (GetClientByClientListItem(item) != null)
                return true;
            return false;
        }


        public static Client GetClientByClientListItem(String item)
        {
            String locale = Client.GetLocaleFromClientListItem(item);
            String[] clientStr = ClientDAL.GetClientDataReader(locale);
            if (clientStr != null)
            {
                Client client = new Client();
                client.Name = clientStr[0];
                client.Locale = clientStr[1];
                client.Region = clientStr[2];
                client.GameFolder = clientStr[3];
                return client;
            }
            else return null;
        }

        public static Client GetClientByLocale(String locale)
        {
            String[] clientStr = ClientDAL.GetClientDataReader(locale);
            if (clientStr != null)
            {
                Client client = new Client();
                client.Name = clientStr[0];
                client.Locale = clientStr[1];
                client.Region = clientStr[2];
                client.GameFolder = clientStr[3];
                return client;
            }
            else return null;
        }
    }
}
