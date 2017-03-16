using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PortCharacter : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("portal"))
        {
            Debug.Log("portal");
            SceneManager.LoadScene("Fight");
            
            
            

        }

    }
}
