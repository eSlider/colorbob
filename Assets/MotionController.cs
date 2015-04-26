using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

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

	void OnCollisionEnter(Collision collision) {

		if(Regex.Match( collision.collider.name, "^Wall").Success){
			print(collision.collider.name);
			ContactPoint cp = collision.contacts[0];
			Renderer renderWall = cp.otherCollider.GetComponent<Renderer>();
			Renderer renderSphere = cp.thisCollider.gameObject.GetComponent<Renderer>();

			renderSphere.material = renderWall.material;
		}
		
	}
}