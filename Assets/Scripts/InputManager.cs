using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

 

    public void SubmitAnswer(string arg0)
    {
        
        int answer = Int32.Parse(arg0);
        Debug.Log(answer);
        
    }


}
