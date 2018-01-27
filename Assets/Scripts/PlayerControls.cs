using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	private float verticalVelocity;
	private float gravity = 20.0f;
	private float jumpForce = 10.0f;
	private float walk = 10.0f;

	private CharacterController controller;





	private void Start(){
		controller = GetComponent<CharacterController> ();
	}


	private void FixedUpdate()
	{

		float move = 0f;
		if (Input.GetKey (KeyCode.D)) {
			if (transform.GetChild (1).rotation.y < 0.7f) {
				
				transform.GetChild (1).Rotate (280.0f * Vector3.up * Time.deltaTime, Space.World);
			}


			move += walk;
		}
		if (Input.GetKey (KeyCode.A)) {
			if (transform.GetChild (1).rotation.y > -0.76f) {
				transform.GetChild (1).Rotate (-280.0f * Vector3.up * Time.deltaTime, Space.World);
			}
			move -= walk;
		}
		Vector3 moveVector;
		if (controller.isGrounded) 
		{	
			verticalVelocity = -gravity * Time.deltaTime;
			if (Input.GetKey (KeyCode.W)) {
				verticalVelocity = jumpForce;
			}
			else{
				moveVector = new Vector3 (move, 0, 0);
				controller.Move (moveVector * Time.deltaTime);
				return;
			}
		} 
		else {
			verticalVelocity -= gravity * Time.deltaTime;

		}


	 	moveVector = new Vector3 (move, verticalVelocity, 0);
		controller.Move (moveVector * Time.deltaTime);

	}
	

}
