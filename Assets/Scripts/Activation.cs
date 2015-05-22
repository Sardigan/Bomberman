using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Activation : MonoBehaviour
{
	
		public  int power;
		private float t = 0;
		private int pos = 0;
		private int tmp = 0;
		private bool b = true;
		private bool isRightFree = true;
		private bool isLeftFree = true;
		private bool isUpFree = true;
		private bool isDownFree = true;
		public Transform explosion;		
	
		// Use this for initialization
		void Start ()
		{					
				power = GameObject.Find ("Player").GetComponent <ControllerForPhone> ().power; 
				t = Time.time + 3;
		}
		// Update is called once per frame
		void Update ()
		{
				
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
			
						if (hitRight.collider != null && hitRight.collider.tag == "Block") {										
								isRightFree = false;
						}
						if (hitLeft.collider != null && hitLeft.collider.tag == "Block") {
								isLeftFree = false;								
						}
			
						if (hitUp.collider != null && hitUp.collider.tag == "Block") {
								isUpFree = false;						
				
						}
			
						if (hitDown.collider != null && hitDown.collider.tag == "Block") {
								isDownFree = false;								
						}
			
						//right
						if (isRightFree) {
								Instantiate (explosion, new Vector3 (x + pos, y, -1), 
				             Quaternion.Euler (0, 0, 0));
								if (hitRight.collider != null && hitRight.collider.tag == "Box") {										
										isRightFree = false;
										Destroy (hitRight.transform.gameObject);
								}
						}
			
						//left						
						if (isLeftFree) {								
								Instantiate (explosion, new Vector3 (x - pos, y, -1), 
				             Quaternion.Euler (0, 180, 0));
								if (hitLeft.collider != null && hitLeft.collider.tag == "Box") {										
										isLeftFree = false;
										Destroy (hitLeft.transform.gameObject);
								}
						}
			
						//up						
						if (isUpFree) {								
								Instantiate (explosion, new Vector3 (x, y + pos, -1), 
				             Quaternion.Euler (0, 0, 90));	
								if (hitUp.collider != null && hitUp.collider.tag == "Box") {										
										isUpFree = false;
										Destroy (hitUp.transform.gameObject);
								}
						}
			
						//down						
						if (isDownFree) {								
								Instantiate (explosion, new Vector3 (x, y - pos, -1),	
				             Quaternion.Euler (0, 0, 270));	
								if (hitDown.collider != null && hitDown.collider.tag == "Box") {										
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
				if (tmp == power) {
						Destroy (gameObject, 0.1f);
				}
		}
	
}
