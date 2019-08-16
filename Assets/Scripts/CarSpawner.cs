using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;

    public float spawnDelay = .3f;
    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            Spawncar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    private void Spawncar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnpoint = spawnPoints[randomIndex];
        
        Instantiate(car, spawnpoint.position, spawnpoint.rotation);
    }
}
