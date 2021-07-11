using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject Zombie;
    public float spawnTime;
    public float spawnDelay;
    public float spawnStop = 0;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", spawnTime, spawnDelay);

    }

    public void Spawn()
    {
        Instantiate(Zombie, transform.position, transform.rotation);
        spawnStop++;
        
        if (spawnStop == 10)
        {
            CancelInvoke("Spawn");
        }
       
    }

}
