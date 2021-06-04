using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject[] meteors;
    public Transform[] spawns;
    private int randomMeteors;
    private int randomSpawns;
    private float spawnTime = 4f;
    private float delay;
    void Start()
    {
        GiveRandomNumbers();
    }

    
    void Update()
    {
        SpawnMeteors();
    }

    private void SpawnMeteors ()
    {
        delay += Time.deltaTime;
        if (delay >= spawnTime)
        {
            Instantiate(meteors[randomMeteors], spawns[randomSpawns]);
            GiveRandomNumbers();
            delay = 0;
        }
    }

    private void GiveRandomNumbers()
    {
        randomMeteors = Random.Range(0, 4);
        randomSpawns = Random.Range(0, 2);
    }
    
}

