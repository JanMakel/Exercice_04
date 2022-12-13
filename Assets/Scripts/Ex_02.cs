using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    public float centimetres;
    
    private float inches(float cent)
    {
        float inch = (cent / 2.54f);
        return inch;
    }


    private void Start()
    {
        inches(centimetres);
    }
}
