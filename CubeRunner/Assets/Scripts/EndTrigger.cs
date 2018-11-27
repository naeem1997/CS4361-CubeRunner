using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;
    
    //Is attached to the END trigger box at the end of the level and will automatically run when player hits it
	void OnTriggerEnter ()
	{
		gameManager.LevelComplete();
	}

}
