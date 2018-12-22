using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu_script : MonoBehaviour {

	public static bool Gameispaused = false;

	public GameObject pauseMenuUI;
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Gameispaused){
				Resume();
			}
			else{
				Pause();
			}
		}
	}

	void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		Gameispaused = false;
	}

	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		Gameispaused = true;
	}

	public void Restart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
