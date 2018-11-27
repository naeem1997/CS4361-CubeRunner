using UnityEngine;
//Controls the camera, follows player as they progess
public class Camera : MonoBehaviour {

	public Transform player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		// Set our position to the players position and offset it
		transform.position = player.position + offset;
	}
}
