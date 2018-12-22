using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_over_screen : MonoBehaviour {

	public void Restart(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{	
		Application.Quit();
	}
}
