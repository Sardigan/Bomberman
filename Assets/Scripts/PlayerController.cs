using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public Controller player;
		public int speed = 5;
		public Transform bomb;
		private bool exists = false;
		private float tm;

		void Start ()
		{
				tm = (int)Time.time;
		}
		
		// Update is called once per frame
		void Update ()
		{
				player.Controlling (speed, (int)Input.GetAxis ("Horizontal"), (int)Input.GetAxis ("Vertical"));
				int x = Mathf.RoundToInt (transform.position.x);
				int y = Mathf.RoundToInt (transform.position.y);
			
				if (x % 2 != 0) {
						x = x - 1;
				}

				if (y % 2 != 0) {
						y = y - 1;
				}
			
				if (Input.GetKeyDown ("space") && exists == false) {            
						Instantiate (bomb, new Vector3 (x, y, transform.position.z), 
				             Quaternion.identity);
						exists = true;	
						tm += 10;
				}
				if ((int)Time.time == tm) {						
						exists = false;						
				}
		}

}