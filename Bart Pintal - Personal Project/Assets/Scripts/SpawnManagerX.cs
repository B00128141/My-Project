using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 5;
    private float spawnInterval = 1.5f;
    private PlayerControllerX playerControllerScript;
    
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    void SpawnObjects ()
    {
        Vector3 spawnLocation = new Vector3(30, Random.Range(3, 9), -1);
        int index = Random.Range(0, objectPrefabs.Length);
        if (!playerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }
    }
}
