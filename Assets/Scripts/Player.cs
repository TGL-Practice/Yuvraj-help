using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Animator anim;
    public Transform housepos;
    public Transform deadpos;
    public static bool safe1_click = false;
    public bool safe1_clicked = false;
    public float speed = 25;
    public Rigidbody rb;
    Collider mycollider;
    float Walk = 8;
    float jump = 7;
    float sadWalk = 6;
    float idle = 0;
    public static bool stopwalking = false;
    public static bool Jump = false;
    public static bool sadwalk = false;
    public static bool freeze = false;
    public static bool yourchance = false;
    public static bool movement = true;
    public bool movement23 = true;
    // Start is called before the first frame update
    void Start()
    {
        
        mycollider = transform.GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        anim.SetFloat("Animation", Walk);
        stopwalking = false;
        Jump = false;
        freeze = false;
    }


    // Update is called once per frame
    void Update()
    {
        movement23 = movement;
        if (movement23 == true)
        {
            safe1_click = safe1_clicked;
            rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.y, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
       
        if (Jump == true)
        {
            anim.SetFloat("Animation", jump);
        }
        if (Jump == true)
        {
            anim.SetFloat("Animation", sadWalk);
        }
        if (stopwalking == true)
        {
            anim.SetFloat("Animation", idle);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stop")
        {
            Debug.Log("Stopped");
            spawner.stopspawn = true;
            movement = false;
        }
        if (collision.gameObject.tag == "dec")
        {
            Debug.Log("oh");
            freeze = true;
        }

    }
    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("Spawning");
        if (collision.gameObject.tag == "stop")
        {
            
            spawner.stopspawn = false;
            movement = true;
        }
        if (collision.gameObject.tag == "dec")
        {
            Debug.Log("oh");
            freeze = false;
           
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "fre")
        {
            spawner.yourchance = true;
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "dec")
        {
            freeze = true;
            Debug.Log("oh");
        }
        if (other.gameObject.tag == "new")
        {
            yourchance = true;
            Debug.Log("stopstop");
        }
        if (other.gameObject.tag == "con")
        {
            Debug.Log("collide happened");
            movement = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "dec")
        {
            freeze = false;
            Debug.Log("oh");
        }
        
    }

}
