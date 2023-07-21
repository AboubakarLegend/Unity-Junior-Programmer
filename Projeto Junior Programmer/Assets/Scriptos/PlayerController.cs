using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tank;
    private float speed = 2.0f;
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
        transform.Translate(Vector3.forward *Time.deltaTime * speed);
        speed = speed + 0.04f;
    }
}
