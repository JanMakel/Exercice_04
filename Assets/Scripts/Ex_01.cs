using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    public int money;


    private void moneybox(int coins)
    {
        money = money + coins;
        Debug.Log($"In the money box you have a total of {money} coins");
    }

    private void Start()
    {
        moneybox(5);
    }
}
