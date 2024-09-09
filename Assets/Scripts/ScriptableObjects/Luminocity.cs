using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luminocity : MonoBehaviour
{
    public float luminocity;
    public float db;

    private float lRef = 3183;

    public void CalculateLuminocity()
    {
        // Calcule luminocity base on dbs
        luminocity = lRef / (Mathf.Pow(10, db / 10));

        Debug.Log("Luminocity calculated" + gameObject.name + " " + luminocity.ToString());
    }
}
