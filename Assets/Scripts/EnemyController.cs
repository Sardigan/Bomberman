using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
		public Controller enemy;
		private int move_x;
		private int move_y;
		private bool b = true;
		private float t = 0;
		private int tmp = 0;
		// Use this for initialization
		void Start ()
		{
				move_x = 1;
				move_y = 0;
				t = Time.time;
		}

		void OnCollisionEnter2D (Collision2D col)
		{				
				if (col.gameObject.name == "Player") {
						Destroy (col.gameObject);
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				RaycastHit2D hit1;
				RaycastHit2D hit2;
				RaycastHit2D hit3;
				RaycastHit2D hit4;

				int x = (int)transform.position.x;
				int y = (int)transform.position.y;

				
					
			
				hit1 = Physics2D.Raycast (new Vector2 (transform.position.x + 2, transform.position.y), Vector2.right, 0);
				hit2 = Physics2D.Raycast (new Vector2 (transform.position.x - 2, transform.position.y), -Vector2.right, 0);
				hit3 = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y + 2), Vector2.up, 0);
				hit4 = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y - 2), -Vector2.up, 0);
			
				//right

				if (hit1.collider != null && (hit1.collider.name == "Cube" || hit1.collider.name == "wall4" || hit1.collider.name == "box")) {										
						move_x = -1;	
						move_y = 0;
						Debug.Log (hit1.collider.name);

				}
				

			
				//left						
			
				if (hit2.collider != null && (hit2.collider.name == "Cube" || hit2.collider.name == "wall2" || hit2.collider.name == "box")) {
						move_x = 1;
						move_y = 0;
						Debug.Log (hit2.collider.name);
				}

			
				//up
			

				if (hit3.collider != null && (hit3.collider.name == "Cube" || hit3.collider.name == "wall3" || hit3.collider.name == "box")) {
						move_x = 0;			
						move_y = -1;
						Debug.Log (hit3.collider.name);
				} 

			
				//down						
		
				
				if (hit4.collider != null && (hit4.collider.name == "Cube" || hit4.collider.name == "wall1" || hit4.collider.name == "box")) {
						move_x = 0;			
						move_y = 1;
						Debug.Log (hit4.collider.name);
				} 


				
				if (hit1.collider != null && hit2.collider != null && hit1.collider.name == "Cube" && hit2.collider.name == "Cube") {
						move_x = 0;
						move_y = 1;
				}
				if (hit3.collider != null && hit4.collider != null && hit3.collider.name == "Cube" && hit4.collider.name == "Cube") {
						move_x = 1;
						move_y = 0;
				}

			


				enemy.Controlling (1, move_x, move_y);
		 
				
		}
}
