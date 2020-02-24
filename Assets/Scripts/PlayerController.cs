using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] string moveAxis = "Vertical";
  [SerializeField] float speed = 10;
  [SerializeField] bool hasPowerup = false;

  Rigidbody playerRb;
  GameObject focalPoint;

  // Start is called before the first frame update
  void Start()
  {
    playerRb = GetComponent<Rigidbody>();
    focalPoint = GameObject.Find("Focal Point");
  }

  // Update is called once per frame
  void Update()
  {
    var playerMovement = Input.GetAxis(moveAxis);
    playerRb.AddForce(
      focalPoint.transform.forward * playerMovement * speed);
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Powerup"))
    {
      hasPowerup = true;
      Destroy(other.gameObject);
    }
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Opponent") && hasPowerup)
    {
      Debug.Log("Player collided with " + collision.gameObject.name
        + " with hasPowerup set to " + hasPowerup);
    }
  }
}
