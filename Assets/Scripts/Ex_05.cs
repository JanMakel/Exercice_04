using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    public bool Ofb;
    public float x;
    public float y;
    public float z;

    private bool OutOfBounds(float limitX, float limitY, float limitZ)
    {
        if (transform.position.x <= limitX && transform.position.x >= limitX * -1)
        {
            return Ofb == true;
        }
        else if(transform.position.y <= limitY && transform.position.y >= limitY * -1)
        {
            return Ofb == true;
        }
        else if (transform.position.z <= limitZ && transform.position.z >= limitZ * -1)
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

        OutOfBounds(x, y ,z);

        if(Ofb == true)
        {
            Debug.Log("The object it's not out of bounds");
        }
        else
        {
            Debug.Log("The object it's out of bounds");
        }

        
    }
}
