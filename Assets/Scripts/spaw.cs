using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    public float startTimeBTwSpawn;

    public float timeBTwSpawn;

    public GameObject[] enemies;
    public static bool stopspawner = false;
    public static bool afterspawner = false;
    private void Start()
    {

    }
    public void Update()
    {
        if (stopspawner == false)
        {
            Debug.Log("stopspawner = false");
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
            Debug.Log("stopspawner = true");
        }
    }

}
