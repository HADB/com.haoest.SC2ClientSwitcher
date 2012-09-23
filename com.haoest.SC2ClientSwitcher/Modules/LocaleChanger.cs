using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace com.haoest.SC2ClientSwitcher.Modules
{
    class LocaleChanger
    {
        public static void ChangeVarTXT(String relocalizeLanguage, String relocalizeAsset)
        {
            //修改 variable.txt
            try
            {
                var sc2VarLocation = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\StarCraft II\\Variables.txt";
                BackupFile(sc2VarLocation);//备份文件
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

                var text = File.ReadAllText(sc2VarLocation);
                int localeIdDataIndex = text.IndexOf("localeiddata=") + 13;
                int localeIdAssetsIndex = text.IndexOf("localeidassets=") + 15;
                //MessageBox.Show(localeIdDataIndex + " " + localeIdAssetsIndex);
                //如果localeidassets不存在
                if (localeIdAssetsIndex == 14)
                {
                    text = text + "localeidassets=" + relocalizeAsset + "\r\n";
                    File.WriteAllText(sc2VarLocation, text);
                }
                //如果localeiddata不存在
                if (localeIdDataIndex == 12)
                {
                    text = text + "localeiddata=" + relocalizeLanguage + "\r\n";
                    File.WriteAllText(sc2VarLocation, text);
                }

                if (localeIdDataIndex != 12 && localeIdAssetsIndex != 14)
                {
                    var originalLanguageSearch = "localeiddata=" + text.Substring(localeIdDataIndex, 4);
                    var relocalizeLang = "localeiddata=" + relocalizeLanguage;
                    var originalAssetSearch = "localeidassets=" + text.Substring(localeIdAssetsIndex, 4);
                    var relocalizeAsst = "localeidassets=" + relocalizeAsset;
                    text = text.Replace(originalLanguageSearch, relocalizeLang);
                    text = text.Replace(originalAssetSearch, relocalizeAsst);
                    File.WriteAllText(sc2VarLocation, text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void BackupFile(String filePath)
        {
            if (!File.Exists(filePath + ".bak"))
            {
                File.Copy(filePath, filePath + ".bak");
            }
        }
    }
}
