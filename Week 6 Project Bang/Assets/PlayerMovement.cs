using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Windows;

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

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.tag == "hazard")
    //    {
    //        GameManager.instance.subtractHealth();
            
    //    }
    //    else if (other.gameObject.tag == "pickup")
    //    {
    //        GameManager.instance.addAmmo();

    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hazard")
        {
            GameManager.instance.subtractHealth();

        }
        else if (collision.gameObject.tag == "pickup")
        {
            GameManager.instance.addAmmo();
            Destroy(collision.gameObject);
        }
    }
}






