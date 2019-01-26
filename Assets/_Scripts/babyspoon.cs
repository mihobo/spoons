using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyspoon : MonoBehaviour
{

    private Rigidbody rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
