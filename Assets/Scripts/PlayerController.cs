using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	
	void FixedUpdate ()  {		 			
		float move_x = Input.GetAxis("Horizontal");
		float move_z = Input.GetAxis("Vertical");

        rigidbody.velocity = new Vector3(move_x * speed, 0, rigidbody.velocity.z);
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, move_z * speed);
	}

	// Update is called once per frame
	void Update () {

	}
}
