using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInputHandle : MonoBehaviour {
    //public string text;
    public void TextInput(string input)
    {
        GameObject.FindGameObjectWithTag("Manager").GetComponent<Settings>().userInput = input;
       // text = input;
    }
}
