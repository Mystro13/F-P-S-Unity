using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField]
    private float rotSpeed = 1.0f;

    public bool IsOnTheGround = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Input.GetAxis("Mouse X");
        //float y = Input.GetAxis("Mouse Y");

        //transform.Rotate(new Vector3(y * rotSpeed, x * rotSpeed, 0));

        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1))
        {
            if (hit.transform != null)
            {
                IsOnTheGround = true;
                Debug.Log(hit.transform.name);
            }
        }
        else
        {
            IsOnTheGround = false;
        }
    }
}
