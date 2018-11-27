using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attached to the powerup object and runs when player hits it
public class PowerUpCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
