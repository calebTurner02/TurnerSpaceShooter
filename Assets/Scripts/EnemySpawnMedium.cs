using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMedium : MonoBehaviour
{
   [SerializeField] Transform Enemy;
    [SerializeField] float fltTimer = 5f;
   
   void Start() 
   {
       Instantiate(Enemy);
   }
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
        Enemy.transform.position = new Vector3(10,-1,1);
    }
}
