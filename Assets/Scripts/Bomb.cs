using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		public  int power;
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
						gameObject.AddComponent ("CircleCollider2D");	
						b1 = false;
				}

				int x = (int)transform.position.x;
				int y = (int)transform.position.y;

				if ((int)Time.time == tm + 3 && b2 == true) {
						
						for (int i = 0; i < power; i += 2) {								
										Instantiate (explosion, new Vector3 (x + i, y, transform.position.z - 1), 
			                                            explosion.transform.rotation);
										Instantiate (explosion, new Vector3 (x - i, y, transform.position.z - 1), 
			             								explosion.transform.rotation);
										Instantiate (explosion, new Vector3 (x, y + i, transform.position.z - 1), 
			             								explosion.transform.rotation);
										Instantiate (explosion, new Vector3 (x, y - i, transform.position.z - 1), 
				             							explosion.transform.rotation);	
										
								
						}
						b2 = false;

				}		
				
				Destroy (gameObject, 5);			
		}

}
