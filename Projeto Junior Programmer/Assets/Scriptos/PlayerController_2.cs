using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour
{
    private float speed = 0.0f;
    private float turnspeed = 6.0f;
    void Start()
    {
        print(gameObject.name);
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            speed = speed + 0.03f;
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                if (speed > 0)
                {
                    speed = speed - 0.07f;
                }
                else if (speed <= 0)
                {
                    speed = -1.0f;
                }
            }
            else if (speed < 0)
            {
                speed = speed + 0.03f;
            }
            else if (speed > 0)
            {
                speed = speed - 0.03f;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (speed > 0)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);
            }
            else if (speed < 0)
            {
                transform.Rotate(Vector3.down * Time.deltaTime * turnspeed);
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (speed > 0)
            {
                transform.Rotate(Vector3.down * Time.deltaTime * turnspeed);
            }
            else if (speed < 0)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);
            }
        }
    }
}
