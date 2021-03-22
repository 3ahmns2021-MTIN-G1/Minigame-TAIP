using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;
    public string links;
    public string rechts;
    public string oben;
    public int moveForce;
    public int jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(links))
        {
            rb.AddForce(new Vector3(-moveForce, 0, 0),ForceMode.Force);
           
        }

        else if (Input.GetKeyDown(rechts))
        {
            rb.AddForce(new Vector3(moveForce, 0, 0), ForceMode.Force);
          
        }

        else if (Input.GetKeyDown(oben))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Force);
      
        }

    }
}
