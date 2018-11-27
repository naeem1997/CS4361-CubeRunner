using UnityEngine;

public class Movement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float momentum = 2000f;	// Variable that controls forward momentum
	public float sideMotion = 100f;  // Variable that controls sideway force when "a" or "d" pushed

    //A different update function that handles movement
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, momentum * Time.deltaTime);
		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sideMotion * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sideMotion * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

    //Every frame the speed is increased, adding more difficulty
    void Update()
    {
        momentum += 20;
    }
}
