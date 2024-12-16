using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luminocity : MonoBehaviour
{
    [SerializeField] public float luminocity;
    [SerializeField] public float db;
    [SerializeField] public bool attenuating = true;
    //[SerializeField] public bool detected = true;

    [SerializeField] public bool finish = false;
    
    private float lRef = 3183;
    public float dbChange = 4;
    public float maxLumRegistered;


    public void CalculateLuminocity()
    {

        // Calcule luminocity base on dbs
        if (attenuating)
        {
            if (dbChange < 1) return; 
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
            if (dbChange < 1) return;
            Debug.Log("Increasing intensity");
            
            db -= dbChange;
            if (db < 0)
            {
                
                db = 0;
            }
            luminocity = lRef / (Mathf.Pow(10, db / 10));
        }



        Debug.Log("Luminocity calculated" + gameObject.name + " " + luminocity.ToString());
    }
}
