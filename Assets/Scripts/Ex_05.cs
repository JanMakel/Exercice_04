using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Variables of the limits of x, y and z  
    public float x;
    public float y;
    public float z;

    //Funciton that returs a bool true if the object that have the script it is in the bounds
    private bool OutOfBounds(float limitX, float limitY, float limitZ)
    {
        if (transform.position.x <= limitX && transform.position.x >= limitX * -1)
        {
            return true;
        }
        else if(transform.position.y <= limitY && transform.position.y >= limitY * -1)
        {
            return  true;
        }
        else if (transform.position.z <= limitZ && transform.position.z >= limitZ * -1)
        {
            return true;
        }
        //if the object is not in one of the bounds the function will say that the bool is false - then if it's false the object is out of bounds
        else
        {
            return false;
        }
    }

    private void Start()
    {
        //Call of the function
        if (OutOfBounds(x, y, z))
        {
            Debug.Log("The object it's not out of bounds");
        }
        else
        {
            Debug.Log("The object it's out of bounds");
        }

        
    }
}
