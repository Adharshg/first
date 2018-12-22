using UnityEngine;

public class CollMovement : MonoBehaviour {

	public Playermovement movement;
	public GameObject gameoverUI;
	public GameObject FinishUI;

	void OnCollisionEnter (Collision collisioninfo){
		if (collisioninfo.collider.tag=="Obstacle"){
			movement.enabled=false;
			gameoverUI.SetActive(true);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Obstacle")){
			gameoverUI.SetActive(true);
		}

		if (other.gameObject.CompareTag("Finish")){
			Time.timeScale = 0f;
			FinishUI.SetActive(true);
		}

	}
}
