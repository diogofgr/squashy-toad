using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

	private Vector3 jumpVector = new Vector3(0,1,1);

	void Start() {
		
	}

	void FixedUpdate() {
		Debug.DrawRay (transform.position, jumpVector, Color.blue);

		var projectedJumpVector = Vector3.ProjectOnPlane (jumpVector, Vector3.up);

		var radiansToRotate = Mathf.Deg2Rad * 45;
		var rotatedJumpVector = Vector3.RotateTowards(projectedJumpVector, Vector3.up, radiansToRotate, 0);

		Debug.DrawRay (transform.position, projectedJumpVector, Color.blue);
		Debug.DrawRay (transform.position, rotatedJumpVector.normalized, Color.red);

		if (Input.GetMouseButtonDown(0)){
			GetComponent<Rigidbody>().AddForce (jumpVector, ForceMode.Impulse);
		}
	}

}
