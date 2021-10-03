using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public bool IsOnTheGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
