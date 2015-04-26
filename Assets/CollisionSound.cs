using UnityEngine;
using System.Collections;



public class CollisionSound : MonoBehaviour
{
	private AudioSource audiosrc;

	void Start ()
	{
		audiosrc = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision collision)
	{
		audiosrc.Play();
	}
}
