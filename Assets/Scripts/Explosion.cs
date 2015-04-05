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
		if (col.gameObject.name == "Player"  || col.gameObject.name == "Enemy") {
						Destroy (col.gameObject, 0.2f);
				}
		}
		// Update is called once per frame
		void Update ()
		{				
				Destroy (gameObject, 2);	
				
		}
}