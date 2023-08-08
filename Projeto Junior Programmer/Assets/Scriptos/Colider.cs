using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    private int pontos1 = 500;
    private int pontos2 = 750;
    public GameObject crate;
    public GameObject placa;
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "a")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("");
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Obstacle")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Obstacle obs = collision.gameObject.GetComponent<Obstacle>();
            if (obs.qual == 0)
            {
                print(obs.points);
                obs.qual = 1;
            }
            //if (collision.collider == crate)
            //{
            //    Debug.Log(pontos1);
            //}
            //if (collision.collider == placa)
            //{
            //    Debug.Log(pontos2);
            //}
            //If the GameObject has the same tag as specified, output this message in the console

        }
    }
}
