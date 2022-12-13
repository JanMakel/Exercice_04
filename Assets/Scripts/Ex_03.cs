using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    public float upperlimit;
    public float lowerlimit;

    private Vector3 Generate(float upper, float lower)
    {
        
        return new Vector3(Random.Range(lower, upper), Random.Range(lower, upper), Random.Range(lower, upper));

    }

    private void Start()
    {
        Generate(upperlimit, lowerlimit);
    }
}
