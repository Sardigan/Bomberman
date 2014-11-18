using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{	
		
		// Use this for initialization
		void Start ()
		{

		}

		void OnCollisionEnter2D (Collision2D col)
		{
				if (col.gameObject.name == "Player" || col.gameObject.name == "box" || col.gameObject.name == "Enemy") {
						Destroy (col.gameObject);
				}
		}
		// Update is called once per frame
		void Update ()
		{

				Destroy (gameObject, 3);
	
		}
}
