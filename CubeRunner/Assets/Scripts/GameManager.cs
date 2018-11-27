using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	bool gameEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;
    public Text score;
    public ScoreKeeper playerScore;

	public void LevelComplete ()
	{
        //TODO have the player score be displayed on level complete screen
        //score.text = playerScore.scoreText.ToString();
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameEnded == false)
		{
			gameEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}

        //TODO Display 'GAME OVER' screen with score displayed 
        //TODO give player option to restart rather than automatically restart
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
