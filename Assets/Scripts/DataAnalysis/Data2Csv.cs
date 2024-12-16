using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Meta.WitAi;
using Unity.VisualScripting;
using UnityEngine;

public class Data2Csv : MonoBehaviour
{
    public GameEvent OnStartAnalysis;
    [SerializeField] string filename;

    [System.Serializable]
    public class Player
    {
        public string patientName;
        public int id = 1;
        public string eye = "OD";
        public string date;
        public string time;
        public int age = 30 ;
        public string type = "pwg";
        public int fpr = 0 ;
        public int fnr = 0 ;
        public int fl = 0;
        public string duration;
        public List<int> playerList = new List<int>();
    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }
    public PlayerList myPatientList = new PlayerList();
    private void Start()
    {
        filename = Application.dataPath+"/CSV/"+filename+".csv";
    }
    public void WriteCSV(Component sender, object results)
    {

        List<float> stimulies = new List<float>();
        string headings = "";
        if (myPatientList.player.Length>0)
        {
            Debug.Log("Test Starting");
            if (gameObject.TryGetComponent<RandomLigths>(out RandomLigths lista))
            {
                var cent = true;
                
                while (cent)
                {
                    for (int i = 1; i <= lista._ligths.Count; i++)
                    {

                        var objeto = "l"+i.ToString(); 
                        Debug.Log(objeto);
                        if (lista._ligths[i-1].name == objeto)
                        {
                            if (lista._ligths[i - 1].gameObject.TryGetComponent<Luminocity>(out Luminocity estimulo))
                            {
                                stimulies.Add(estimulo.db);
                            }
                                
                        }
                        

                        //var Stimuli = program.transform.GetChild(i);
                        //if (Stimuli = null) continue;

                    }
                    if (stimulies.Count == lista._ligths.Count)
                    {
                        cent = false;
                    }
                    cent = false;
                }
            }

            TextWriter tw = new StreamWriter(filename, false);
            for (int i = 1; i <= stimulies.Count; i++)
            {
                headings = headings+ "," + "l" + i;
            }
            headings = "id,eye,date,time,age,type,fpr,fnr,fl,duration" + headings;


            tw.WriteLine(headings);
            tw.Close();

            tw = new StreamWriter(filename, true);


            for (int i = 0; i < myPatientList.player.Length; i++)
            {

                DateTime dt = DateTime.Now;
                myPatientList.player[0].date = dt.ToString("dd MMM yyyy");
                myPatientList.player[0].time = dt.ToString("HH:mm:ss");

                var patientData = myPatientList.player[0].id +
                                    "," + myPatientList.player[0].eye +
                                    "," + myPatientList.player[0].date +
                                    "," + myPatientList.player[0].time +
                                    "," + myPatientList.player[0].age +
                                    "," + myPatientList.player[0].type +
                                    "," + myPatientList.player[0].fpr +
                                    "," + myPatientList.player[0].fnr +
                                    "," + myPatientList.player[0].fl +
                                    "," + myPatientList.player[0].duration;
                for (int j = 0; j < stimulies.Count; j++)
                {
                    patientData = patientData + "," + stimulies[j];
                    Debug.Log(stimulies[j]);
                }
                tw.WriteLine(patientData);
            }

            tw.Close();
            Debug.Log("DONE");
            
        }
    }

    public void CreateCSV(Component sender, object data)
    {
        WriteCSV(this, "gaa");
        Debug.Log("CSV exported");
        OnStartAnalysis.Raise(this, "go manito");   
    }
}
