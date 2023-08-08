using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer_2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -5);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (offset == new Vector3(0, 5, -5))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                offset = new Vector3(0, 3, 2);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                offset = new Vector3(0, 5, -5);
            }
        }


    }
}
