using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoprefe : MonoBehaviour
{
    public static GameObject refe;
    public Transform myTrns;
    public static Transform stopTrns;

    private void Start()
	{
        myTrns = transform;
        stopTrns = myTrns;
    }

	private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            refe = collision.gameObject;
        }
    }
}
