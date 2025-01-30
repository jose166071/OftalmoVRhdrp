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

    public string eye;

    private string _centinel; 
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame

    public void SavePatient(Component sender, object data)
    {
        _centinel = sender.gameObject.name;
        Debug.Log(_centinel );
        switch (_centinel)
        {
            case "Name":
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientNameData))
                {
                    patientName= patientNameData.text;
                }
                break;
            case "Age":
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientAge))
                {
                    age = patientAge.text;
                }
                
                break;
            case "Id":
                if (sender.TryGetComponent<TMP_InputField>(out TMP_InputField patientId))
                {
                    id = patientId.text;
                }
                break;
            case "Ojo Derecho":
                eye = "OD";
                break;
            case "Ojo Izquierdo":
                eye = "OS";
                break;
        }
    }
}
