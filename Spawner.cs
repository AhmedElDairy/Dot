﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnrate = 1f;
    public GameObject hexagonPre;
    private float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
      if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPre, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnrate;
        }  

    }
}
