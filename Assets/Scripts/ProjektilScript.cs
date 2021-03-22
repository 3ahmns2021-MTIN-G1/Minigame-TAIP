using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjektilScript : MonoBehaviour
{

    private float time;
    public float destroyTime;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= destroyTime)
        {
            Destroy(gameObject);
        }
    }
}
