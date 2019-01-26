using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody rb;
  public float speed = 5;
  public float rotationSpeed = 5;
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
    float verticalRotation = Input.GetAxis("LookVertical");
    float horizontalRotation = Input.GetAxis("LookHorizontal");
    Vector3 rotationVector = new Vector3(verticalRotation, horizontalRotation, 0);

    Debug.Log(verticalRotation);
    Debug.Log(horizontalRotation);

    Quaternion deltaRotation = Quaternion.Euler(rotationVector * rotationSpeed * Time.deltaTime);
    rb.MoveRotation(rb.rotation * deltaRotation);

    rb.AddForce(strafeMovement * speed, 0, forwardMovement * speed, ForceMode.Impulse);
  }
}
