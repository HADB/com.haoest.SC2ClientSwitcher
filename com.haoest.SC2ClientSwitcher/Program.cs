using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.haoest.SC2ClientSwitcher
{
    static class Program
    {

        public static string[] languageList = {
                                                  "AM - English (US) - enUS",
                                                  "AM - Español (Latin America) - esMX",
                                                  "AM - Português (Brazil) - ptBR",
                                                  "CN - 简体中文 (PR China, simplified) - zhCN",
                                                  "EU - English (UK) - enGB",
                                                  "EU - Français - frFR",
                                                  "EU - Deutsch - deDE",
                                                  "EU - Italiano - itIT",
                                                  "EU - Polski - plPL",
                                                  "EU - Русский - ruRU",
                                                  "EU - Español (Spain) - esES",
                                                  "KR/TW - 한국어 - koKR",
                                                  "KR/TW - 繁體中文 (Taiwan, tranditional) - zhTW",
                                                  "SEA - English (Singapore) - enSG"
                                              };

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
