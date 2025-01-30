using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramSelection : MonoBehaviour
{
    public enum Program
    {
        veinteL = 0,
        veinteR = 1,
        diez = 2
    };
    [SerializeField] private Program program;
    [SerializeField] private GameEvent SelecProgram;


    // Start is called before the first frame update
    void Start()
    {
        
        var patientInfo = GameObject.Find("PatientData").GetComponent<DataPatient>();
        if (patientInfo.eye == "OD") 
        {
            program = Program.veinteR;   
        }
        else if (patientInfo.eye == "OS")
        {
            program = Program.veinteL;
        }
        else
        {
            
        }
        SelecProgram.Raise(this, program.ToString());

    }

    // Update is called once per frame
    void Update()
    {

    }
}
