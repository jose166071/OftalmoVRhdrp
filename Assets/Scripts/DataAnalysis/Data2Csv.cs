using System.Collections;
using System.Collections.Generic;
using System.IO;
using Meta.WitAi;
using UnityEngine;

public class Data2Csv : MonoBehaviour
{
    string filename = "";

    [System.Serializable]
    public class Player
    {
        public string patientName;
        public int id;
        public int age;
    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }
    public PlayerList myPatientList = new PlayerList();
    private void Start()
    {
        filename = Application.dataPath + "/CSV/test1.csv";
    }
    public void WriteCSV()
    {
        if (myPatientList.player.Length>0)
        {
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("Name, id, age");
            tw.Close();

            tw = new StreamWriter(filename, true);

            for (int i = 0; i < myPatientList.player.Length; i++)
            {
                tw.WriteLine(myPatientList.player[i].patientName + 
                    "," + myPatientList.player[i].id + 
                    "," + myPatientList.player[i].age);
            }

            tw.Close();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WriteCSV();
            Debug.Log("CSV exported");
        }
    }
}
