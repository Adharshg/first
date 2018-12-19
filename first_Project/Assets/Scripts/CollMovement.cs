using UnityEngine;

public class CollMovement : MonoBehaviour {

	public Playermovement movement;

	void OnCollisionEnter (Collision collisioninfo){
		if (collisioninfo.collider.tag=="Obstacle"){
			movement.enabled=false;
		}
	}
}
