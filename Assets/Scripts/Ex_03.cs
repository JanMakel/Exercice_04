using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Variables to store the lmitis
    public float upperlimit;
    public float lowerlimit;

    //Function that on a gived random numbers generates a new vector 3 in the limits we putted
    private Vector3 Generate(float upper, float lower)
    {
        
        return new Vector3(Random.Range(lower, upper), Random.Range(lower, upper), Random.Range(lower, upper));

    }

    private void Start()
    {
        //Call on the function
        Generate(upperlimit, lowerlimit);
    }
}
