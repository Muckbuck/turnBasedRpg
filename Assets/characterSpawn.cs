using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class characterSpawn : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        /*
        GameObject spawnTile = GameObject.FindGameObjectWithTag("Respawn");
        GameObject character = GameObject.FindGameObjectWithTag("character");
        var spawnTileRend = spawnTile.GetComponent<Renderer>();
        Vector3 spawnTileCenter = spawnTileRend.bounds.center;
        character.transform.position = spawnTileCenter;
        */

    }

    private void Update()
    {
      
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }



}
