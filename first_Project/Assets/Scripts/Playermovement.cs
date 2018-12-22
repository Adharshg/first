using UnityEngine;

public class Playermovement : MonoBehaviour {
	public Rigidbody rb;
	public float fforce=2000f;
	public float sforce=500f;

	void FixedUpdate () {

			rb.AddForce(0,0,fforce*Time.deltaTime);
			
		if(Input.GetKey("d")){
			rb.AddForce(sforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		
		if(Input.GetKey("a")){
			rb.AddForce(-sforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
	}
/*
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Obstacle")){
			gameoverUI.SetActive(true);
		}
	}
*/
}