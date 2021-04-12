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
    public KeyCode schießen;
    public int moveForce;
    public int jumpForce;
    public GameObject kugel;
    private GameObject kugelNeu;
    public int health;
    public Text scoreText;
    public GameObject firepoint;
    public Vector3 shootForce;

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

        if (Input.GetKeyDown(links))
        {
            rb.AddRelativeForce(new Vector3(-moveForce, 0, 0),ForceMode.Force);
           
        }

        else if (Input.GetKeyDown(rechts))
        {
            rb.AddRelativeForce(new Vector3(moveForce, 0, 0), ForceMode.Force);
          
        }

        else if (Input.GetKeyDown(oben))
        {
            rb.AddRelativeForce(new Vector3(0, jumpForce, 0), ForceMode.Force);
      
        }

        else if (Input.GetKeyDown(schießen))
        {
            kugelNeu = Instantiate(kugel, firepoint.transform.position, firepoint.transform.rotation);
            kugelNeu.GetComponent<Rigidbody>().AddRelativeForce(shootForce);
        }
    }
}
