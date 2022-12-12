using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    public string[] wordies;
    public int randomWord;
    public string residual;

    private string sayRandomWord()
    {
        randomWord = Random.Range(0, wordies.Length);
        Debug.Log($"{wordies[randomWord]}");

        return residual;
    }

    private void Start()
    {
        sayRandomWord();
    }
}
