using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
			
		public  int power;
		private float t = 0;
		private int pos = 0;
		private int tmp = 0;
		private bool hasCollider = false;
		private bool b = true;
		private bool isRightFree = true;
		private bool isLeftFree = true;
		private bool isUpFree = true;
		private bool isDownFree = true;
		public Transform explosion;		
		
		// Use this for initialization
		void Start ()
		{					
				t = Time.time + 3;
				
		}
		// Update is called once per frame
		void Update ()
		{
				Destroy (gameObject, 3 + power * 0.2f);
				if ((int)Time.time == (int)t - 1 && hasCollider == false) {						
						gameObject.AddComponent ("CircleCollider2D");	
						hasCollider = true;						
				}
				RaycastHit2D hitRight;
				RaycastHit2D hitLeft;
				RaycastHit2D hitUp;
				RaycastHit2D hitDown;


				int x = (int)transform.position.x;
				int y = (int)transform.position.y;
				

				if (Time.time > t && b == true && tmp <= power) {						

						hitRight = Physics2D.Raycast (new Vector2 (x + pos, y), Vector2.right, 0);
						hitLeft = Physics2D.Raycast (new Vector2 (x - pos, y), -Vector2.right, 0);
						hitUp = Physics2D.Raycast (new Vector2 (x, y + pos), Vector2.up, 0);
						hitDown = Physics2D.Raycast (new Vector2 (x, y - pos), -Vector2.up, 0);

						if (hitRight.collider != null && (hitRight.collider.name == "Cube" || hitRight.collider.name == "wall4")) {										
								isRightFree = false;
						}
						if (hitLeft.collider != null && (hitLeft.collider.name == "Cube" || hitLeft.collider.name == "wall2")) {
								isLeftFree = false;								
						}
			
						if (hitUp.collider != null && (hitUp.collider.name == "Cube" || hitUp.collider.name == "wall3")) {
								isUpFree = false;						

						}
			
						if (hitDown.collider != null && (hitDown.collider.name == "Cube" || hitDown.collider.name == "wall1")) {
								isDownFree = false;								
						}

						//right
						if (isRightFree) {
								Instantiate (explosion, new Vector3 (x + pos, y, transform.position.z), 
				             Quaternion.Euler (0, 0, 0));
								if (hitRight.collider != null && hitRight.collider.name == "box") {										
										isRightFree = false;
										Destroy (hitRight.transform.gameObject);
								}
						}

						//left						
						if (isLeftFree) {								
								Instantiate (explosion, new Vector3 (x - pos, y, transform.position.z), 
				             Quaternion.Euler (0, 180, 0));
								if (hitLeft.collider != null && hitLeft.collider.name == "box") {										
										isLeftFree = false;
										Destroy (hitLeft.transform.gameObject);
								}
						}
			
						//up						
						if (isUpFree) {								
								Instantiate (explosion, new Vector3 (x, y + pos, transform.position.z), 
				             Quaternion.Euler (0, 0, 90));	
								if (hitUp.collider != null && hitUp.collider.name == "box") {										
										isUpFree = false;
										Destroy (hitUp.transform.gameObject);
								}
						}

						//down						
						if (isDownFree) {								
								Instantiate (explosion, new Vector3 (x, y - pos, transform.position.z),	
				             Quaternion.Euler (0, 0, 270));	
								if (hitDown.collider != null && hitDown.collider.name == "box") {										
										isDownFree = false;
										Destroy (hitDown.transform.gameObject);
								}
						}
			
						b = false;	
						t = Time.time;
						pos += 2;
						tmp++;
			
				}
						
				if (Time.time - t > 0.2f) {
						b = true;						
				}
		}

}
