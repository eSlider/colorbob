using UnityEngine;
using System.Collections;

// This is MotionController 

public class MotionController : MonoBehaviour {
	public float speedFactor = 0.1f;
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.forward * speedFactor);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector3.back * speedFactor);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * speedFactor);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector3.left * speedFactor);
		}
	}
}