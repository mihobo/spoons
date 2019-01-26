using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody rb;
  public float speed = 5;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void FixedUpdate()
  {
    float forwardMovement = Input.GetAxis("Vertical");
    float strafeMovement = Input.GetAxis("Horizontal");
    Debug.Log(forwardMovement);
    rb.AddForce(strafeMovement * speed, 0, forwardMovement * speed, ForceMode.Impulse);
  }
}
