using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoprefe : MonoBehaviour
{
    public static GameObject refe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(refe);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            refe = collision.gameObject;
        }
    }
}
