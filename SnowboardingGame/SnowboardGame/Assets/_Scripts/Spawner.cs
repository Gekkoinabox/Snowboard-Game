using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;
    private int i = 0;
    public int waveSize = 5;
    void spawnEnemy()
    {
        for (i = 0; i < waveSize; i++)
        {
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[4].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[5].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[6].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[7].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            
        }
    }
	// Use this for initialization
	void Awake () {
        spawnEnemy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
