using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    // Array of prefabs to use as tiles
    [SerializeField] private GameObject[] tiles = new GameObject[5];
    private characterSpawn spawn;

    // Structure of Level1
    string[] mapStructLevel1 = System.IO.File.ReadAllLines(@"E:\Programmering\Unity_project\New Unity Project\Assets\map.txt");

    // Structure of Fight scene
    private string[] mapStructFight = new string[]
        {
            "00000000000000",  "00000000000000", "02000000000040", "00000000000000", "00000000000000", "00000000000000"
        };






    // The size of a tile
    public float TileSize
    {
        get { return tiles[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2; }
    }



    // Use this for initialization
    void Start()
    {
        
        // DEBUG, print current scene
        Scene scene = SceneManager.GetActiveScene();
        
        Debug.Log(scene.name);

        // get the active scene to determin what map to load

        CreateLevel(scene);

        // Spawn character on spawnTile (Put this in another class later)
        GameObject spawnTile = GameObject.FindGameObjectWithTag("Respawn");
        GameObject character = GameObject.FindGameObjectWithTag("character");
        var spawnTileRend = spawnTile.GetComponent<Renderer>();
        Vector3 spawnTileCenter = spawnTileRend.bounds.center;
        character.transform.position = spawnTileCenter;


        GameObject mob = GameObject.FindGameObjectWithTag("mob");
        GameObject mobSpawnTile = GameObject.FindGameObjectWithTag("mobSpawnTile");
        var mobSpawnTileRenderer = mobSpawnTile.GetComponent<Renderer>();
        Vector3 mobSpawnTileCenter = mobSpawnTileRenderer.bounds.center;
        mob.transform.position = mobSpawnTileCenter;


    }


    private void CreateLevel(Scene scene)
    {
        // Height and width of the map
        string[] mapStruct = null;
        if(scene.name == "Level1")
        {
            mapStruct = mapStructLevel1;
        }
        if(scene.name == "Fight")
        {
            mapStruct = mapStructFight;
        }
        int mapWidth = mapStruct[0].Length;
        int mapHeight = mapStruct.Length;
        
        /**************
         * Looping through the array containing the map structure, 
         * placing every string in a char array to be able to decide what prefab to render
         * ************/
        for (int y = 0; y < mapHeight; y++)
        {
            char[] type = mapStruct[y].ToCharArray();
            for (int x = 0; x < mapWidth; x++)
            {
                PlaceTile(x, y, type[x].ToString());
            }
        }
    }

    private void PlaceTile(int x, int y, string type)
    {
        int tileIndex = int.Parse(type);
        // The position of the top left corner of the camera
        Vector3 startingpoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        // Instantiates the prefabs in the tiles array
        GameObject newTile = Instantiate(tiles[tileIndex]);
        // Set the position of each tile, starting from the top left corner of the camera
        newTile.transform.position = new Vector3(startingpoint.x + (TileSize * x), startingpoint.y - (TileSize * y), 0);

    }
}
