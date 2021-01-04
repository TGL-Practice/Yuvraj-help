using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe : MonoBehaviour
{
    public GameObject GameOver;

    public void Start()
    {
        GameOver.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bad")
        {
            GameOver.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bad")
        {
            GameOver.SetActive(true);
        }
    }
}
