using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform Enemy;
    [SerializeField] Transform spawnPoints;
    [SerializeField] float fltTimer = 5f;
    void Update()
    {
        
        fltTimer -= Time.deltaTime;

        if(fltTimer < 0)
        {
            setposition();
            Instantiate(Enemy);
            fltTimer = 5f;
        }
    }

    void setposition()
    {
        Enemy.transform.position = new Vector3(10,2,6);
    }
}
