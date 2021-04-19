using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawnScript : MonoBehaviour
{
    public int anzahl;
    public GameObject tower;

    void Start()
    {
        for (int i = 0; i < anzahl; i++)
        {
            Vector3 towerPos;
            Vector3 towerRot;
            towerPos.x = Random.Range(-3f,10f);
            towerPos.y = -1.232032f;
            towerPos.z = Random.Range(3f, -6f);
            towerRot.x = 0;
            towerRot.y = Random.Range(0f, 360f);
            towerRot.z = 0;

            Instantiate(tower, towerPos, Quaternion.Euler(towerRot));
        }
    }
}
