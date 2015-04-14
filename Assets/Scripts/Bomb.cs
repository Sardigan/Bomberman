using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
			
		
		private float t = 0;
		private bool hasCollider = false;		
		public Transform activator;		
		
		// Use this for initialization
		void Start ()
		{					
				t = Time.time + 3;
				
		}
		// Update is called once per frame
		void Update ()
		{
					
				if ((int)Time.time == (int)t - 1 && hasCollider == false) {						
						gameObject.AddComponent <CircleCollider2D>();	
						hasCollider = true;						
				}
				
				if (Time.time > t) {
						Destroy (gameObject);
				}
		}

}
