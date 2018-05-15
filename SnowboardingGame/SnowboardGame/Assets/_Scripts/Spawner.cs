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
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[0].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[0].transform.position);
            whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[0], spawnLocations[1].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[1].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[1].transform.position);
            whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[0], spawnLocations[2].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[2].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[2].transform.position);
            whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[0], spawnLocations[3].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[3].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[3].transform.position);
            whatToSpawnClone[4] = Instantiate(whatToSpawnPrefab[0], spawnLocations[4].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[4].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[4].transform.position);
            whatToSpawnClone[5] = Instantiate(whatToSpawnPrefab[0], spawnLocations[5].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[5].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[5].transform.position);
            whatToSpawnClone[6] = Instantiate(whatToSpawnPrefab[0], spawnLocations[6].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[6].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[6].transform.position);
            whatToSpawnClone[7] = Instantiate(whatToSpawnPrefab[0], spawnLocations[7].position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Debug.Log("Spawn Location = " + spawnLocations[7].position);
            Debug.Log("Clone Location = " + whatToSpawnClone[7].transform.position);

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
