using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DataPatient : MonoBehaviour
{
    public string patientName;

    public string age;

    public string id;

    private int _centinel = 0; 
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame

    public void SavePatient(Component sender, object data)
    {
        switch (_centinel)
        {
            case 0:
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientNameData))
                {
                    patientName= patientNameData.text;
                }
                _centinel++;
                break;
            case 1:
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientAge))
                {
                    age = patientAge.text;
                }
                _centinel++;
                break;
            default:
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientId))
                {
                    id = patientId.text;
                }
                break;
        }
    }
}
