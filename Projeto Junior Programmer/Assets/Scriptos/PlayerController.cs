using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tank;
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
        transform.Translate(0, 0, 1);
    }
}
