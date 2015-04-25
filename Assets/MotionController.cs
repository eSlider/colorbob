using UnityEngine;
using System.Collections;

public class MotionController : MonoBehaviour
{
	
	public float speed = 3;
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
}