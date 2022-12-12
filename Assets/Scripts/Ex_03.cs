using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    public float upperlimit;
    public float lowerlimit;

    private Vector3 Generate(float upper, float lower)
    {
        Random.Range(upper, lower);
        return new Vector3(upper, 0, lower);

    }

    private void Start()
    {
        Generate(upperlimit, lowerlimit);
    }
}
