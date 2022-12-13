using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    //Variable that exist to store the money
    public int money;

    //This function stores the money you put in your money box with the call
    private void moneybox(int coins)
    {
       
        money = money + coins;
        Debug.Log($"In the money box you have a total of {money} coins");
    }

    private void Start()
    {
        //This call puts money inside the money box
        moneybox(5);
    }
}
