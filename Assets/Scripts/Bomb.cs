using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		public  int power;
		private int tm = 0;
		private float t = 0;
		private int pos = 2;
		private bool b1 = true;
		private bool b2 = true;
		public Transform explosion;		
		
		// Use this for initialization
		void Start ()
		{		
				tm = (int)Time.time;
				t = Time.time + 3;
		}
		// Update is called once per frame
		void Update ()
		{
				Destroy (gameObject, power);	
		
				if ((int)Time.time == tm + 2 && b1 == true) {						
						gameObject.AddComponent ("CircleCollider2D");	
						b1 = false;
						Debug.Log (Time.time);
				}
				Ray2D ray1 = new Ray2D (transform.position, transform.forward);
				Ray2D ray2 = new Ray2D (transform.position, -transform.forward);
				Ray2D ray3 = new Ray2D (transform.position, transform.up);
				Ray2D ray4 = new Ray2D (transform.position, -transform.up);
				

	
				int x = (int)transform.position.x;
				int y = (int)transform.position.y;

				if (Time.time > t && b2 == true && pos < power) {								
								
						Instantiate (explosion, new Vector3 (x + pos, y, transform.position.z - 1), 
			             explosion.transform.rotation);

						Instantiate (explosion, new Vector3 (x - pos, y, transform.position.z - 1), 
			             explosion.transform.rotation);

						Instantiate (explosion, new Vector3 (x, y + pos, transform.position.z - 1), 
			             explosion.transform.rotation);

						Instantiate (explosion, new Vector3 (x, y - pos, transform.position.z - 1),	
			             explosion.transform.rotation);	

						b2 = false;	
						t = Time.time;
						pos += 2;
			
				}
						
				if (Time.time - t > 0.2f) {
						b2 = true;
						
				}
		}

}
