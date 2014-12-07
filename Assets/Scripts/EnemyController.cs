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
				move_y = 1;
				t = Time.time;
		}

		void OnCollisionEnter2D (Collision2D col)
		{
				/*if (col.gameObject.name == "wall1") {
						move_x = 1;
						move_y = 0;
				}
				if (col.gameObject.name == "wall2") {
						move_x = 0;
						move_y = -1;
				}
				if (col.gameObject.name == "wall3") {
						move_x = -1;
						move_y = 0;
				}
				if (col.gameObject.name == "wall4") {
						move_x = 0;
						move_y = 1;
				}
				if (col.gameObject.name == "Player") {
						Destroy (col.gameObject);
				}*/
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 fwd = transform.TransformDirection (Vector3.up);
				if (Physics.Raycast (transform.position, fwd, 1f))
						Debug.Log ("There is something in front of the object!");
				enemy.Controlling (1, move_x, move_y);

				if (Time.time > t && b == true) {
						tmp = Random.Range (1, 5);
						b = false;
				}
				if (tmp == 1) {
						move_x = -1;
						move_y = 0;
				}
				if (tmp == 2) {
						move_x = 1;
						move_y = 0;
				}
				if (tmp == 3) {
						move_x = 0;
						move_y = -1;
				}	
				if (tmp == 4) {						
						move_x = 0;
						move_y = 1;
				}	
				if (Time.time - t > 1f) {
						b = true;
			
				}
				
		}
}
