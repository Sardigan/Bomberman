using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

		public Controller enemy;
		private int move_x;
		private int move_y;
		// Use this for initialization
		void Start ()
		{
				move_x = 0;
				move_y = 0;
		}

		void OnCollisionEnter2D (Collision2D col)
		{
				if (col.gameObject.name == "wall1") {
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
				}
		
		}	
	
		// Update is called once per frame
		void Update ()
		{
				enemy.Controlling (1, move_x, move_y);
		}
}
