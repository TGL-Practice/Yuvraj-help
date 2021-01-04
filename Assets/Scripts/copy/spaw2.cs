using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw2 : MonoBehaviour
{

    public float startTimeBTwSpawn;

    public float timeBTwSpawn;

    public GameObject[] enemies;
    public bool workerstopspawn;
    public static bool workestopspawn;
    public static bool stopspawn;
    public static bool stopspawner = false;
    public static bool afterspawner = false;

    public void Update()
    {
        workerstopspawn = workestopspawn;
        
        if (stopspawner == false)
        {
            
            if (timeBTwSpawn <= 0)
            {
                int rand = Random.Range(0, enemies.Length);
                Instantiate(enemies[rand], transform.position, Quaternion.identity);
                timeBTwSpawn = startTimeBTwSpawn;
            }
            else
            {
                timeBTwSpawn -= Time.deltaTime;
            }
        }
        if (stopspawner == true)
        {
            
        }
    }

}
