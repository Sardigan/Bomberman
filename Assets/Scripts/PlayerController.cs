using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public Controller player;
		public int speed;
		public Transform bomb;
		private bool exists = false;		

		void Start ()
		{
				
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
				}
				if (GameObject.Find ("Bomb(Clone)") == null) {
						exists = false;
				}
		}

}