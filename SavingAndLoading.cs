using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SavingAndLoading : MonoBehaviour {

    [Serializable]
    public class Analytics : MonoBehaviour
    {

        public int NumberOfBoltsCollected { get; set; }
        public int NumberOfNutsCollected { get; set; }
        public bool FoundJetPack { get; set; }

        public float TimeLevelStarted { get; set; }
        public float TimeElapsed { get; set; }
        public string NameOfCurrentLevel { get; set; }
        public Transform PlayerCurrentPosition { get; set; }

        void Awake()
        {
            DontDestroyOnLoad(this);
            TimeLevelStarted = Time.realtimeSinceStartup;
            TimeElapsed = 0f;
            NameOfCurrentLevel = "This should be changed by the level (scene) loaded.";
            PlayerCurrentPosition = this.transform;     // This should be a reference to the player transform and kept 
                                                        // up-to-date by the player GameObject.
        }

        void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            Analytics data = new Analytics();
            data.NumberOfBoltsCollected = NumberOfBoltsCollected;
            data.NumberOfNutsCollected = NumberOfNutsCollected;
            data.FoundJetPack = FoundJetPack;
            data.TimeLevelStarted = TimeLevelStarted;
            data.TimeLevelStarted = TimeElapsed;
            data.NameOfCurrentLevel = NameOfCurrentLevel;
            data.PlayerCurrentPosition = PlayerCurrentPosition;

            bf.Serialize(file, data);
        }

        void Load()
        {
            if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
                Analytics data = (Analytics)bf.Deserialize(file);
                file.Close();

                NumberOfBoltsCollected = data.NumberOfBoltsCollected;
                NumberOfNutsCollected = data.NumberOfNutsCollected;
                FoundJetPack = data.FoundJetPack;
                TimeLevelStarted = data.TimeLevelStarted;
                TimeElapsed = data.TimeElapsed;
                NameOfCurrentLevel = data.NameOfCurrentLevel;
                PlayerCurrentPosition = data.PlayerCurrentPosition;
            }
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            TimeElapsed += Time.deltaTime;
        }
    }
}
