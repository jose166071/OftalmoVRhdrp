using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramSelection : MonoBehaviour
{
    public enum Program
    {
        treinta = 0,
        veinte = 1,
        diez = 2
    };
    [SerializeField] private Program program;
    [SerializeField] private GameEvent SelecProgram;


    // Start is called before the first frame update
    void Start()
    {
        var programa = program.ToString();
        SelecProgram.Raise(this, programa);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
