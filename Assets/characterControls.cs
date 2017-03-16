using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class characterControls : MonoBehaviour
{
    
    [SerializeField] private float speed;
    public Transform target;
  
  

    
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        var animator = gameObject.GetComponent<Animator>();
        var animation = gameObject.GetComponent<Animation>();
        Scene scene = SceneManager.GetActiveScene();
        var fightScene = scene.name == "Fight";


        if (!fightScene)
        {
            if (!Input.anyKey)
            {
                animator.SetInteger("Walk", 0);



            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);

                animator.SetInteger("Walk", 1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);

                animator.SetInteger("Walk", 2);

            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);

                animator.SetInteger("Walk", 3);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);

                animator.SetInteger("Walk", 4);
            }
        }
        else
        {
            animator.SetInteger("Walk", 0);
        }


        
        

    }
}
