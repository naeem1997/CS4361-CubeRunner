using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

	public Movement movement;
    public Transform player;
    public ScoreKeeper score;

	// This function runs when we hit another object.
	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
        if (collisionInfo.collider.tag == "PowerUp")
        {
            score.powerUp = true;
        }
	}

}
