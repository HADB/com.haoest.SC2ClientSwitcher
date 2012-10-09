using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using com.haoest.Utils.Text;
using com.haoest.Utils.IO;

namespace com.haoest.SC2ClientSwitcher.Modules
{
    class LocaleChanger
    {
        /// <summary>
        /// 修改 variable.txt
        /// </summary>
        /// <param name="relocalizeLanguage">新的语言</param>
        /// <param name="relocalizeAsset">新的语音包</param>
        public static void ChangeVarTXT(String relocalizeLanguage, String relocalizeAsset)
        {
            try
            {
                String sc2VarLocation = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\StarCraft II\\Variables.txt";
                FileBackup.MultipleBackup(sc2VarLocation, 4);//备份文件
                //如果文件不存在，创建一个
                if (!File.Exists(sc2VarLocation))
                {
                    File.Create(sc2VarLocation);
                }

                //如果文件只读，取消只读
                FileInfo fInfo = new FileInfo(sc2VarLocation);
                if (fInfo.IsReadOnly)
                {
                    fInfo.IsReadOnly = false;
                }

                String text = File.ReadAllText(sc2VarLocation);

                //如果localeidassets不存在
                if (text.IndexOf("localeidassets=") == -1)
                {
                    text = text + "localeidassets=" + relocalizeAsset + "\r\n";
                    File.WriteAllText(sc2VarLocation, text);
                }
                //如果localeiddata不存在
                if (text.IndexOf("localeiddata=") == -1)
                {
                    text = text + "localeiddata=" + relocalizeLanguage + "\r\n";
                    File.WriteAllText(sc2VarLocation, text);
                }

                text = ReplaceText.ReplaceAfterSearchString(text, "localeiddata=", 4, relocalizeLanguage);
                text = ReplaceText.ReplaceAfterSearchString(text, "localeidassets=", 4, relocalizeAsset);
                File.WriteAllText(sc2VarLocation, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
