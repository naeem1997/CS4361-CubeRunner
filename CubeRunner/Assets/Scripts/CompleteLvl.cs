using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl : MonoBehaviour {
    //Runs when player has collided/fallen off/finished
	public void LoadNext ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
