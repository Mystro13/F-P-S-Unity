using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    [SerializeField]
    private float rotSpeed = 1.0f;

    [SerializeField]
    Transform lookUpDown;
  

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0, x * rotSpeed * Time.deltaTime, 0));
        lookUpDown.Rotate(new Vector3(y * rotSpeed * Time.deltaTime,0, 0));
    }
}
