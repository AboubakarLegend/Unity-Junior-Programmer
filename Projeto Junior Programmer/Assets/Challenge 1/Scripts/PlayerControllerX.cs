using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float speed2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        //verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.right * verticalInput * Time.deltaTime *speed);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        //rotationSpeed = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.right * verticalInput * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * speed2 *speed2);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * speed2 * speed2);
        }
    }
}
