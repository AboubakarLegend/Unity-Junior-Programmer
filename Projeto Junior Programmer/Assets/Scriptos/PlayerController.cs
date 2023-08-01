using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tank;
    private float speed = 0.0f;
    private float turnspeed = 6.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Vector3 p = tank.transform.position;
        //    p = new Vector3(p.x,p.y,p.z+1);
        //    tank.transform.position = p;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    Vector3 p = tank.transform.position;
        //    p = new Vector3(p.x, p.y, p.z-1);
        //    tank.transform.position = p;
        //}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            speed = speed + 0.03f;
        }
        else
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (speed > 0)
                {
                    speed = speed - 0.07f;
                }
                else if (speed <= 0)
                {
                    speed = - 1.0f;
                }
            }
            else if (speed < 0)
            {
                speed=speed+0.03f;
            }
            else if (speed > 0)
            {
                speed = speed - 0.03f;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(speed > 0)
            { 
                transform.Rotate(Vector3.up * Time.deltaTime * turnspeed); 
            }
            else if (speed < 0)
            {
                transform.Rotate(Vector3.down * Time.deltaTime * turnspeed);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
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
