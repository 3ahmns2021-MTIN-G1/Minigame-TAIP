using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShootScript : MonoBehaviour
{
    private float time;
    public float shootTime;
    public GameObject kugel;
    private GameObject kugelNeu;
    public GameObject firepoint;
    public float shootForce;

    void Update()
    {
        time += Time.deltaTime;
        if (time >= shootTime)
        {
            kugelNeu = Instantiate(kugel, firepoint.transform.position, firepoint.transform.rotation);
            kugelNeu.GetComponent<Rigidbody>().AddRelativeForce(-shootForce,0,0);
            time = 0;
        }
    }
}
