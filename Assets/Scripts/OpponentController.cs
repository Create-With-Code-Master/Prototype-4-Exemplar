using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentController : MonoBehaviour
{
  [SerializeField] float speed = 5.0f;

  Rigidbody opponentRb;
  GameObject player;

  // Start is called before the first frame update
  void Start()
  {
    opponentRb = GetComponent<Rigidbody>();
    player = GameObject.Find("Player");
  }

  // Update is called once per frame
  void Update()
  {
    var lookDirection =
      (player.transform.position - transform.position).normalized;

    // Lesson does not use Time.deltaTime - why?
    opponentRb.AddForce(lookDirection * speed);
  }
}
