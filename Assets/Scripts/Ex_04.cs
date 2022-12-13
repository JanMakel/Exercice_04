using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Variables with one array to store words
    public string[] wordies;
    public int randomWord;
    //This variable only exist to store a residual string it's not really useful but if it didin't
    public string residual;

    //Function that generates a random word from the array we created 
    private string sayRandomWord()
    {
        randomWord = Random.Range(0, wordies.Length);
        Debug.Log($"{wordies[randomWord]}");
                return residual;
    }

    private void Start()
    {
        //Call of the function
        sayRandomWord();
    }
}
