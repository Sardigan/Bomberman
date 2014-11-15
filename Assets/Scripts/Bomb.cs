using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		private float tm = 0;
		private bool b1 = true;
		private bool b2 = true;
		public Transform explosion;
		
		// Use this for initialization
		void Start ()
		{
				tm = (int)Time.time + 2;
		}

		// Update is called once per frame
		void Update ()
		{
				if ((int)Time.time == tm && b1 == true) {						
						gameObject.AddComponent ("SphereCollider");	
						b1 = false;
				}
				if ((int)Time.time == tm + 3 && b2 == true) {
						Instantiate (explosion, new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z), 
			                                            explosion.transform.rotation);
						b2 = false;

				}
				Destroy (gameObject, 5);			
		}

}
