using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    public GameObject GameOver;

    public void Start()
    {
        GameOver.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "good")
        {
            GameOver.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "good")
        {
            GameOver.SetActive(true);
        }
    }
}
