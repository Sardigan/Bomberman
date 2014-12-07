using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		public  int power;
		private float t = 0;
		private int pos = 2;
		private bool b1 = true;
		private bool b2 = true;
		private bool b3 = true;
		private bool b4 = true;
		private bool b5 = true;
		private bool b6 = true;
		public Transform explosion;		
		
		// Use this for initialization
		void Start ()
		{					
				t = Time.time + 3;
		}
		// Update is called once per frame
		void Update ()
		{
				Destroy (gameObject, power);	
		
				if ((int)Time.time == (int)t - 1 && b1 == true) {						
						gameObject.AddComponent ("CircleCollider2D");	
						b1 = false;
						//Debug.Log (2D ray1 = new Ray2D (transform.position, 
				}
				RaycastHit2D hit1;
				RaycastHit2D hit2;
				RaycastHit2D hit3;
				RaycastHit2D hit4;

				int x = (int)transform.position.x;
				int y = (int)transform.position.y;

				if (Time.time > t && b2 == true && pos < power) {	

						hit1 = Physics2D.Raycast (new Vector2 (x + pos, y), Vector2.right, 0);
						hit2 = Physics2D.Raycast (new Vector2 (x - pos, y), -Vector2.right, 0);
						hit3 = Physics2D.Raycast (new Vector2 (x, y + pos), Vector2.up, 0);
						hit4 = Physics2D.Raycast (new Vector2 (x, y - pos), -Vector2.up, 0);
						
						//right
						if (b3 == true) {
								Instantiate (explosion, new Vector3 (x + pos, y, transform.position.z - 1), 
				             explosion.transform.rotation);
								if (hit1.collider != null && (hit1.collider.name == "Cube" || hit1.collider.name == "wall4" || hit1.collider.name == "box")) {										
										b3 = false;
								}
								
						}

						//left						
						if (b4 == true) {
								Instantiate (explosion, new Vector3 (x - pos, y, transform.position.z - 1), 
				             explosion.transform.rotation);
								if (hit2.collider != null && (hit2.collider.name == "Cube" || hit2.collider.name == "wall2" || hit2.collider.name == "box")) {
										b4 = false;
								}
						}
			
						//up
						
						if (b5 == true) {
								Instantiate (explosion, new Vector3 (x, y + pos, transform.position.z - 1), 
				             explosion.transform.rotation);
								if (hit3.collider != null && (hit3.collider.name == "Cube" || hit3.collider.name == "wall3" || hit3.collider.name == "box")) {
										b5 = false;
								} 
						}
			
						//down						
						if (b6 == true) {
								Instantiate (explosion, new Vector3 (x, y - pos, transform.position.z - 1),	
				             explosion.transform.rotation);
								if (hit4.collider != null && (hit4.collider.name == "Cube" || hit4.collider.name == "wall1" || hit4.collider.name == "box")) {
										b6 = false;
								} 
						}
			
						b2 = false;	
						t = Time.time;
						pos += 2;
			
				}
						
				if (Time.time - t > 0.2f) {
						b2 = true;
						
				}
		}

}
