using System;
using System.IO;
using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

namespace GachiData {
    public class GachiData : MonoBehaviour
    {
        string filepath = Application.persistentDataPath + "/" + "GachiData";

        [SerializeField]
        static GachiStats gachi;


        public void readGachiData() {
            string json = File.ReadAllText(filepath);
            gachi = JsonUtility.FromJson<GachiStats>(json);
        }

        public void writeGachiData() {
            string json = JsonUtility.ToJson(gachi, true);
            File.WriteAllText(filepath,json);
        }

        [Serializable]
        public struct GachiStats {
            public int health;
            public string spritePath;
        }  
    }

}
