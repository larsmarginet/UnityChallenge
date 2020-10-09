using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject upgrade;
    public uint Ypos = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(0, 20), Ypos, Random.Range(0, 20));
        Instantiate(upgrade, spawnPos, upgrade.transform.rotation);
    }
}
