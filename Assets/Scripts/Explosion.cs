using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{	
		
		
		// Use this for initialization
		void Start ()
		{
		
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				if (col.gameObject.name == "Player" || col.gameObject.name == "box" || col.gameObject.name == "Enemy") {
						Destroy (col.gameObject);
				}
				if (col.gameObject.name == "Cube") {
						Destroy (gameObject);		
				}
		}
		// Update is called once per frame
		void Update ()
		{				
				Destroy (gameObject, 2);	
				
		}
}