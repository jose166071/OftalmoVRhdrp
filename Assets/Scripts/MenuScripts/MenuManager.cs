using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField]private TMP_InputField _PatinetName;
    [SerializeField] private TMP_InputField _age;
    [SerializeField] private TMP_InputField _id;
    [SerializeField] private Button _derecha;
    [SerializeField] private Button _izquierda;

    [SerializeField] private GameEvent SetData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(1);
    }

    public void SavePatient()
    {
        SetData.Raise(_PatinetName, _PatinetName);
        SetData.Raise(_age, _age);
        SetData.Raise(_id, _id);
    }

    public void SetName()
    {
        Debug.Log(_PatinetName.text);
        SetData.Raise(_PatinetName, _PatinetName.text);
    }
    
    public void SetAge()
    {
        Debug.Log(_age.text);
        SetData.Raise(_age, _age.text);
    }
    
    public void SetId()
    {
        Debug.Log((_id.text));
        SetData.Raise(_id, _id.text);
    }
    public void SetEyeIz()
    {
        Debug.Log("Set Left");
        SetData.Raise(_izquierda, "");
    }
    public void SetDer()
    {
        Debug.Log("Set Rigth");
        SetData.Raise(_derecha, "");
    }


}
