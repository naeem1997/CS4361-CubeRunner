using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private bool isLost;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isLost = false;
    }
    /*
	// Update is called once per frame
	void Update () {
		
	}*/

    private void FixedUpdate()
    {
        if (!isLost)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(speed * movement);
            speed += 0.01f;
        }
        else
        {
            //rb.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
            //rb.SetDensity(9999999);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isLost)
        {
            //can add collisions with other stuff
            if (collision.gameObject.name.Contains("ScaryCube"))
            {
                isLost = true;
                rb.isKinematic = true;
                speed = 0;
                Debug.Log("game over!");
            }
            else if (collision.gameObject.name.Contains("NiceCube"))
            {
                //can do lots of things here
                rb.isKinematic = true;
                Destroy(collision.gameObject);
                rb.isKinematic = false;
            }
            Debug.Log(collision.gameObject.name);
            //Debug.Log(collision.gameObject.name.Contains("ScaryCube"));
        }
        //Debug.Log(speed);
    }
}
