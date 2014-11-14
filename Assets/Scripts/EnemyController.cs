using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

		public Controller enemy;
		private float move_x = 1;
		private float move_z = 0;
		// Use this for initialization
		void Start ()
		{
	
		}

		void OnCollisionEnter (Collision col)
		{
				if (col.gameObject.name == "wall1") {
						move_x = 1;
						move_z = 0;
				}
				if (col.gameObject.name == "wall2") {
						move_x = 0;
						move_z = 1;
				}
				if (col.gameObject.name == "wall3") {
						move_x = -1;
						move_z = 0;
				}
				if (col.gameObject.name == "wall4") {
						move_x = 0;
						move_z = -1;
				}
		
		}	
	
		// Update is called once per frame
		void Update ()
		{		
				enemy.Controlling (1, move_x, move_z);
		}
}
