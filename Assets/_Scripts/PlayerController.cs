
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody rb;
  private Transform transform;
  public float speed = 5;
  public float rotationSpeed = 5;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    transform = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update()
  {
    float verticalRotation = Input.GetAxis("LookVertical");
    float horizontalRotation = Input.GetAxis("LookHorizontal");

    Vector3 rotationVector = new Vector3(verticalRotation, horizontalRotation, 0);

    transform.Rotate(rotationVector);
  }

  void FixedUpdate()
  {
    float forwardMovement = Input.GetAxis("Vertical");
    float strafeMovement = Input.GetAxis("Horizontal");

    if (rb.velocity.x >= 10)
    {
      rb.velocity = new Vector3(10, rb.velocity.y, rb.velocity.z);
    }
    if (rb.velocity.z >= 10)
    {
      rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 10);
    }

    if (rb.velocity.x <= -10)
    {
      rb.velocity = new Vector3(-10, rb.velocity.y, rb.velocity.z);
    }
    if (rb.velocity.z <= -10)
    {
      rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -10);
    }
    rb.AddForce(strafeMovement * speed, 0, forwardMovement * speed, ForceMode.Impulse);
  }
}
