using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public Transform housepos;
    public Transform deadpos;
    public float speed = 90f;
    public float speed2;
    [HideInInspector]
    public bool mustPartorl;
    public static bool fullstop;
    public Rigidbody rb;
    public Transform groundCheckPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed2 * Time.fixedDeltaTime, rb.velocity.y);
    }
    public void die()
    {
        transform.position = Vector3.MoveTowards(transform.position, deadpos.position, speed * Time.deltaTime);
    }
    public void safe()
    {
        transform.position = Vector3.MoveTowards(transform.position, housepos.position, speed * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stop")
        {
            fullstop = true;
            spaw.stopspawner = true;
        }
        if (other.gameObject.tag == "house")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "lava")
        {
            Destroy(this.gameObject);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            Debug.Log("stop");
            fullstop = true;
            spaw.stopspawner = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            Debug.Log("spawning");
            fullstop = false;
            spaw.stopspawner = false;
        }
    }

}
