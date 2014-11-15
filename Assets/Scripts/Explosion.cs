using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}

		void OnCollisionEnter (Collision col)
		{
		if (col.gameObject.name == "Player" || col.gameObject.name == "Enemy" || col.gameObject.name == "box") {
						Destroy (col.gameObject);
				}
		}
		// Update is called once per frame
		void Update ()
		{
				Destroy (gameObject, 4);
	
		}
}
