using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
  [SerializeField] string rotAxis = "Horizontal";
  [SerializeField] float rotSpeed = 30;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    var rotInput = Input.GetAxis(rotAxis);
    transform.Rotate(Vector3.up, rotInput * rotSpeed * Time.deltaTime);
  }
}
