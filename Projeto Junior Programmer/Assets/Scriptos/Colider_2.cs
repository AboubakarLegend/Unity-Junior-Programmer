using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider_2 : MonoBehaviour
{
    public GameObject crate;
    public GameObject placa;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "a")
        {
            Debug.Log("");
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Obstacle obs = collision.gameObject.GetComponent<Obstacle>();
            if (obs.qual == 0)
            {
                print(obs.points);
                obs.qual = 1;
            }
        }
    }
}
