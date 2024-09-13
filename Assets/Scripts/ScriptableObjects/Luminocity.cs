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
            Debug.Log("Attenuating");
            db += dbChange;
            if (db>40)
            {
                db = 40;
            }
            luminocity = lRef / (Mathf.Pow(10, db / 10));
        }
        else 
        {
            Debug.Log("Increasing intensity");
            if (db < 0)
            {
                db = 0;
            }
            db -= dbChange;
            luminocity = lRef / (Mathf.Pow(10, db / 10));
        }



        Debug.Log("Luminocity calculated" + gameObject.name + " " + luminocity.ToString());
    }
}
