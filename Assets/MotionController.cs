using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class MotionController : MonoBehaviour
{
	
	public float speed = 3;
	private Rigidbody rb;

	public float additionalColorPercent = 0.000001F;
	private ContactPoint contactPoint;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

//		audiosrc = GetComponent<AudioSource>();

	}
	
	void Update ()
	{
		// Moving Sphere with keyboard arrows
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);


		if( contactPoint.thisCollider != null){
			// get Sphere and Wall renderers, to get materials
			Renderer renderWall = contactPoint.otherCollider.GetComponent<Renderer>();
			Renderer renderSphere = contactPoint.thisCollider.gameObject.GetComponent<Renderer>();

			renderSphere.material = renderWall.material;
			contactPoint = new ContactPoint();

		}

		 
	}

	void OnCollisionEnter(Collision collision) {
		if(Regex.Match( collision.collider.name, "^Wall").Success){
			print ("start change color");
			contactPoint = collision.contacts[0];


		}

		
	}


}