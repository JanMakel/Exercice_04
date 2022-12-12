using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    public bool Ofb;
    public float lower;
    public float upper;

    private bool outofbounds(float lowerlimit, float upperlimit)
    {
        if (transform.position.x < lowerlimit)
        {
            return Ofb == true;
        }
        else if(transform.position.x > upperlimit)
        {
            return Ofb == true;
        }
        else
        {
            return Ofb == false;
        }
    }

    private void Start()
    {

        outofbounds(lower, upper);

        if(Ofb == true)
        {
            Debug.Log("The object it's out of bounds");
        }
        else
        {
            Debug.Log("The object it's not out of bounds");
        }

        
    }
}
