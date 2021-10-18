using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]
    float bulletLifetime;

    float elapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
     {
        elapsed += Time.deltaTime;

        if (elapsed >= bulletLifetime)
            Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"tag {collision.gameObject.tag}");

        if(collision.gameObject.tag == "target")
        {
            Destroy(collision.gameObject);
            GameManager.instance.checkTargets();
        }
            
    }
}
