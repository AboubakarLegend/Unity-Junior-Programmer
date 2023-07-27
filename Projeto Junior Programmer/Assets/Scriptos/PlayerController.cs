using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tank;
    private float speed = 0.0f;
    private float turnspeed = 5.0f;
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
            speed = speed + 0.02f;
        }
        else
        {
            if(speed <= 0)
            {
                speed=0;
            }
            else if (speed > 0)
            {
                speed = speed - 0.04f;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * turnspeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * turnspeed);
        }
    }
}
