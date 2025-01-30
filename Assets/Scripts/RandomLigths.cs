using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class RandomLigths : MonoBehaviour
{
    [SerializeField] public List<GameObject> _ligths = new List<GameObject>();
    [SerializeField] private GameObject _vienticuatro2Rigth;
    [SerializeField] private GameObject _vienticuatro2Left;
    [SerializeField] private GameObject _diez2;
    [SerializeField] private GameEvent StartTest;



    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void SetProgram(Component sender, object data)
    {
        Debug.Log(data);
        var data2 = data.ToString();
        GameObject a;
        if (data2 == "veinteR")
        {
            Debug.Log(data2);
            a = _vienticuatro2Rigth;
        }
        else if (data2 == "veinteL")
        {
            a = _vienticuatro2Left;
        }
        else
        {
            a = _diez2;
        }

        for (int i = 0; i < a.transform.childCount; i++)
        {
            var Stimuli = a.gameObject.transform.GetChild(i);
            //var Stimuli = program.transform.GetChild(i);
            //if (Stimuli = null) continue;
            _ligths.Add(Stimuli.gameObject);
        }
        
        StartTest.Raise(this, "Empezó");
        Debug.Log("StartTest Raised");
    }
}
