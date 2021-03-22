using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjektilScript : MonoBehaviour
{

    private float time;
    public float destroyTime;
    public int schaden;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= destroyTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerScript>().health -= schaden;
            Destroy(gameObject);
        }
        
    }
}
