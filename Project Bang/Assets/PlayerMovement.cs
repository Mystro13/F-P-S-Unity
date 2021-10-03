using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 1;



    [SerializeField]
    float jumpSpeed = 1;

    Rigidbody rb;
    PlayerPosition playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerPosition = GetComponent<PlayerPosition>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h * moveSpeed,
                                  rb.velocity.y,
                                  v * moveSpeed);


        if (Input.GetButtonDown("Jump"))
        {
            if (playerPosition.IsOnTheGround)
            {
                Jump();
            }
        }
    }





    void Jump()
    {
        //rb.AddForce(Vector3.up * jumpSpeed);
        rb.velocity = new Vector3(rb.velocity.x,
                                    jumpSpeed,
                                    rb.velocity.z);
    }
    
}






