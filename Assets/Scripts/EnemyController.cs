using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

		public Controller enemy;
		private float move_x = 1;
		private float move_y = 0;
		// Use this for initialization
		void Start ()
		{
	
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
		
		}	
	
		// Update is called once per frame
		void Update ()
		{		
				enemy.Controlling (1, move_x, move_y);
		}
}
