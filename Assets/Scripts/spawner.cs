using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public static spawner spawn_ref;
    public float startTimeBtwSpawn;
    public float TimeBtwSpawn;

    public GameObject[] enemies;
    public bool stopspawner;
    public static bool stopspawn = false;
    public GameObject startpos;
    public static bool yourchance = false;
    public string buttonclick = "normalbutton";
    
    public Texture map1;
    // Start is called before the first frame update
    void Start()
    {
        spawn_ref = this;
        yourchance = false;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (startpos.transform.childCount < 0)
        {
            stopspawn = false;
        }
        stopspawner = stopspawn;

        if (stopspawn == false)
        {
            if (TimeBtwSpawn <= 0)
            {
                int rand = Random.Range(0, enemies.Length);
                GameObject inspbj = Instantiate(enemies[rand], transform.position, Quaternion.identity);
                int num = Random.Range(0, 2);
                string tag = num.ToString();

                inspbj.transform.gameObject.name = tag;

                Debug.Log("Tag =  " + inspbj.transform.name);
                inspbj.transform.parent = startpos.transform;
                TimeBtwSpawn = startTimeBtwSpawn;
            }
            else
            {
                TimeBtwSpawn -= Time.deltaTime;
            }
        }
        else
        {
            Player.stopwalking = true;
        }
    }
    public void Onclickfun(GameObject obj)
    {
        switch(obj.name)
        {
            case "Safebutton":
                Debug.Log("Safe Clicked");
                if (Player.yourchance == true)
                {
                    if (startpos.transform.childCount > 0)
                    {
                        startpos.transform.GetChild(0).GetComponent<BoxCollider>().enabled = false;
                        startpos.transform.GetChild(0).transform.parent = null;
                        stopspawn = false;
                        stoprefe.refe.transform.GetComponent<Player>().Jump = true;
                        stoprefe.refe.transform.GetComponent<Player>().sadwalk = false;
                        //Player.Jump = true;
                        Player.movement = true;
                    }
                }
                break;

            case "Safebutton1":
                Debug.Log("Safe1 Clicked");
                if (Player.yourchance == true)
                {
                    if (startpos.transform.childCount > 0)
                    {
                        startpos.transform.GetChild(0).GetComponent<BoxCollider>().enabled = false;
                        startpos.transform.GetChild(0).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                        startpos.transform.GetChild(0).transform.parent = null;
                        stopspawn = false;
                        stoprefe.refe.transform.GetComponent<Player>().Jump = false;
                        stoprefe.refe.transform.GetComponent<Player>().sadwalk = true;
                        //Player.sadwalk = true;
                        Player.movement = true;
                    }
                }
                break;

        }
    }

}
