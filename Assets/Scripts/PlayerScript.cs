using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody rb;
    public KeyCode links;
    public KeyCode rechts;
    public KeyCode oben;
    public KeyCode unten;
    public KeyCode schießen;
    public int moveForce;
    
    public int health;
    public Text scoreText;
 

    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = health.ToString();

        if (Input.GetKey(links))
        {
            rb.AddRelativeForce(new Vector3(-moveForce, 0, 0),ForceMode.Force);
           
        }

        else if (Input.GetKey(rechts))
        {
            rb.AddRelativeForce(new Vector3(moveForce, 0, 0), ForceMode.Force);
          
        }

        else if (Input.GetKey(oben))
        {
            rb.AddRelativeForce(new Vector3(0, 0, moveForce), ForceMode.Force);
      
        }

        else if (Input.GetKey(unten))
        {
            rb.AddRelativeForce(new Vector3(0, 0, -moveForce), ForceMode.Force);

        }
    }
}
