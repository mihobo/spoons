using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoon_spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    float timer = 1.0f;
    
    // Start is called before the first frame update
    void Start() {
    
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0) {
            GameObject babyspoon = Instantiate(objectToSpawn, transform);
            babyspoon.transform.position = transform.position;
            timer = 1.0f;
        }

        Debug.Log(timer);
    }
}