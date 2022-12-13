using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    //Variable of the centimetres we want to change
    public float centimetres;
    

    //Function that changes centimetres to inches and return the inches
    private float inches(float cent)
    {
        float inch = (cent / 2.54f);
        return inch;
    }


    private void Start()
    {
        //Call of the function and Debug to see the results
        inches(centimetres);
        Debug.Log($"{centimetres} centimetres to inches are {inches(centimetres)} inches ");
    }
}
