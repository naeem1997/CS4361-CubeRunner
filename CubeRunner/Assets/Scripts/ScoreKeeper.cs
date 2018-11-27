using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	public Transform player;
	public Text scoreText;
    public bool powerUp = false;

	// Update is called once per frame
	void Update () {
        if (powerUp) //If the powerup has been obtained
            scoreText.text = (player.position.z + 100).ToString("0");
        else
            scoreText.text = player.position.z.ToString("0");
	}
}
