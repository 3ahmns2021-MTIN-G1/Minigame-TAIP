using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody rb;
    public string links;
    public string rechts;
    public string oben;
    public string schießen;
    public int moveForce;
    public int jumpForce;
    public GameObject kugel;
    private GameObject kugelNeu;
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

        else if (Input.GetKeyDown(schießen))
        {
            kugelNeu = Instantiate(kugel, new Vector3(gameObject.transform.position.x + 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            kugelNeu.GetComponent<Rigidbody>().AddForce(new Vector3(500, 0, 0), ForceMode.Force);
        }
    }
}
