using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Compression;
using Windows.Storage;
using System.IO;
using System.Collections.Generic;

namespace Aztec_gold
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public static class SaveGameXML
    {



        public static void SaveGame(int Current = 1,int Count = 1,int eseyScore = 0,int normalScore = 0)
        {       
            StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            ApplicationDataContainer gameDataSettingWrite = ApplicationData.Current.LocalSettings;

            //gameDataSettingWrite.CreateContainer("CURRENT_LEVEL", ApplicationDataCreateDisposition.Always);
            gameDataSettingWrite.Values["CURRENT_LEVEL"] = Current;
            gameDataSettingWrite.Values["LEVEL_COUNTER"] = Count;
            gameDataSettingWrite.Values["ESEY_HSCORE"] = eseyScore;
            gameDataSettingWrite.Values["NORMAL_HSCORE"] = normalScore;
        }


        public static Data ReadDataLevelCurrent()
        {
            Data source = new Data();
            ApplicationDataContainer gameDataSettingRead = ApplicationData.Current.LocalSettings;

            if (gameDataSettingRead.Values["CURRENT_LEVE"] == null)
            {
                gameDataSettingRead.Values["CURRENT_LEVEL"] = 1;
            }
            else
            {
                source.CurrentLevel = (int)gameDataSettingRead.Values["CURRENT_LEVEL"];
            }
            return source;
        }

        public static Data ReadDataLevelCounter()
        {
            Data source = new Data();
            ApplicationDataContainer gameDataSettingRead = ApplicationData.Current.LocalSettings;
            if (gameDataSettingRead.Values["LEVEL_COUNTER"] == null)
            {
                gameDataSettingRead.Values["LEVEL_COUNTER"] = 1;
            }
            else
            { source.LevelCount = (int)gameDataSettingRead.Values["LEVEL_COUNTER"]; }
            return source;
        }

        public static Data ReadDataEseyScore()
        {
            Data source = new Data();
            ApplicationDataContainer gameDataSettingRead = ApplicationData.Current.LocalSettings;
            if (gameDataSettingRead.Values["ESEY_HSCORE"] == null)
            {
                gameDataSettingRead.Values["ESEY_HSCORE"] = 1;
            }
            else
            {
                source.LevelCount = (int)gameDataSettingRead.Values["ESEY_HSCORE"];
            }
            return source;
        }

        public static Data ReadDataNormalScore()
        {
            Data source = new Data();
            ApplicationDataContainer gameDataSettingRead = ApplicationData.Current.LocalSettings;
            if (gameDataSettingRead.Values["NORMAL_HSCORE"] == null)
            {
                gameDataSettingRead.Values["NORMAL_HSCORE"] = 1;
            }
            else
            {
                source.LevelCount = (int)gameDataSettingRead.Values["NORMAL_HSCORE"];
            }
            return source;
        }

    }


}
