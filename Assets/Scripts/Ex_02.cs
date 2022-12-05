using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    public int centimetres;
    public int inch;
    private int inches(int cent)
    {
        inch = (cent / 2.54f);
        return inch;
    }
}
