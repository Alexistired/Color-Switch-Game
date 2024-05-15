using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float startTimeBtwSpawn;
    private float timeBtwSpawn;

	public GameObject[] enemies;

	private void Update()
	{
		if(timeBtwSpawn <= 0){ 
			Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
		} else{ 
			timeBtwSpawn -= Time.deltaTime;
		}
	}

}
