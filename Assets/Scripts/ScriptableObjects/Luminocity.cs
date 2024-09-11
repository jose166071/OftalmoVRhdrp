using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luminocity : MonoBehaviour
{
    [SerializeField] public float luminocity;
    [SerializeField] public float db;
    [SerializeField] public bool attenuating = true;
    [SerializeField] public bool detected = true;
    
    private float lRef = 3183;
    public int dbChange = 4;
    public float maxLumRegistered;


    public void CalculateLuminocity()
    {

        // Calcule luminocity base on dbs
        if (attenuating)
        {
            db += dbChange;
            luminocity = lRef / (Mathf.Pow(10, db / 10));
        }
        else 
        {
            db -= dbChange;
            luminocity = lRef / (Mathf.Pow(10, db / 10));
        }



        //Debug.Log("Luminocity calculated" + gameObject.name + " " + luminocity.ToString());
    }
}
