using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject mob = GameObject.FindGameObjectWithTag("mob");
        GameObject mobSpawnTile = GameObject.FindGameObjectWithTag("mobSpawnTile");
        var mobSpawnTileRenderer = mobSpawnTile.GetComponent<Renderer>();
        Vector3 mobSpawnTileCenter = mobSpawnTileRenderer.bounds.center;
        mob.transform.position = mobSpawnTileCenter;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
