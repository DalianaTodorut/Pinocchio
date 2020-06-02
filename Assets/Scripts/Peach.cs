using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peach : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hrei" + collision.gameObject.name);
        if (collision.gameObject.name == "MaleFree1")
        {
            Debug.Log("Transform Tag is: " + collision.gameObject.name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger!");

    }
}
