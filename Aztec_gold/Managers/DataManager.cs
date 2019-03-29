
namespace Aztec_gold
{
    public class DataManager
    {
        public Data dataCurrentLevel;
        public Data dataLelevelCounter;
        public Data dataHNormalScore;
        public Data dataHEseyScore;
        private static DataManager s_pInstance = null;

        #region Get and Set
        public int LevelCount
        {
            get { return dataLelevelCounter.LevelCount; }
            set { dataLelevelCounter.LevelCount= value; }
        }
        
        public int EasyHighScore
        {
            get { return dataHEseyScore.EasyHighScore; }
            set { dataHEseyScore.EasyHighScore = value; }
        }
        public int NormalHighScore
        {
            get { return dataHNormalScore.NormalHighScore; }
            set { dataHNormalScore.NormalHighScore = value; }
        }

        public int CurrentLevel
        {
            get { return dataCurrentLevel.CurrentLevel; }
            set { dataCurrentLevel.CurrentLevel = value; }
        }
        #endregion


        private DataManager()
        {
            dataCurrentLevel = new Data();
            dataHEseyScore = new Data();
            dataHNormalScore = new Data();
            dataLelevelCounter = new Data();
            LoadData();
        }

        public static DataManager GetInstance()
        {
            if (s_pInstance == null)
            {
                s_pInstance = new DataManager();
                return s_pInstance;
            }
            else
                return s_pInstance;
        }

        private void LoadData()
        {
           // data = SaveGameXML.ReadDataFromXML();
            dataCurrentLevel = SaveGameXML.ReadDataLevelCurrent();
            dataLelevelCounter = SaveGameXML.ReadDataLevelCounter();
            dataHEseyScore = SaveGameXML.ReadDataEseyScore();
            dataHNormalScore = SaveGameXML.ReadDataNormalScore();
        }


        public void SaveData()
        {
            int CurrentSave = CurrentLevel;
            int CountSave = LevelCount;
            int NormalScore = NormalHighScore;
            int EseyScore = EasyHighScore;
            SaveGameXML.SaveGame(CurrentSave,CountSave,EseyScore,NormalScore);
        }

    }
}
