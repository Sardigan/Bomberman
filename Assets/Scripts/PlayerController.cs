using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{ 			
			transform.position += transform.forward * speed * Time.deltaTime;			
		} 
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
		{ 
			transform.position -= transform.forward * speed * Time.deltaTime;
		} 
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
		{ 
			transform.position -= transform.right * speed * Time.deltaTime; 
		} 
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
		{ 
			transform.position += transform.right * speed * Time.deltaTime;
		}
	}
}
