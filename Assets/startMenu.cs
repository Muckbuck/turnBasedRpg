using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour {
    

    private int menuHeight = 500;
    
    private int menuWidth = 1000;
    
    private int menuX = 0;
    
    private int menuY = 0;

    private int startButtonx = 350;
    
    private int startButtonY = 150;
    private int startButtonWidth = 400;
    private int startButtonHeight = 120;

    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(menuX, menuY, menuWidth, menuHeight), "StartMenu");
        
        

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(startButtonx, startButtonY, startButtonWidth, startButtonHeight), "Level1"))
        {
            Application.LoadLevel(2);
           
        }
        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(startButtonx, startButtonY + 200, startButtonWidth, startButtonHeight), "Fight"))
        {
            Application.LoadLevel(1);

        }



    }
}
