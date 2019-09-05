using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities
{

    public static string ProcessText(string input)
    {
        // extra cred
        
        //code goes here
        //determine whether user has a word or a number
        //return 'word' if word (includes ab.23cd)
        //return"number" if number(includes 1.3) etc
        float num;

        if(float.TryParse(input, out num))
        {
            input = "number";
            
        }
        else
        {
            input = "word";
        }

        
        return input;
    }
}

