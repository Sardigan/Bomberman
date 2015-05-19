using UnityEngine;
using System.Collections;

public class ControllerForPhone : MonoBehaviour
{

		public Controller player;
		public float speed;
		public Transform bomb;
		private bool exists = false;
		private Animator anim;
		private bool isFacingLeft = true;
		public Transform activator;
		private bool pressedBomb = false;
		public float move_x = 0;
		public float move_y = 0;
	
		void Start ()
		{
				anim = GetComponent<Animator> ();
				speed = PlayerPrefs.GetFloat ("speedPlayer", speed); 
		
		}

		public void PressedBomb ()
		{
				pressedBomb = true;
		}
		
		public void Pressed ()
		{
				move_x = 0;
				move_y = 0;

		}

		public void Up ()
		{
				move_x = 0;
				move_y = 1;
		}

		public void Down ()
		{
				move_x = 0;
				move_y = -1;
		}

		public void Right ()
		{
				move_x = 1;
				move_y = 0;
		}

		public void Left ()
		{
				move_x = -1;
				move_y = 0;
		}
	
		void FixedUpdate ()
		{
				player.Controlling (speed, move_x, move_y);				
		}

	
		// Update is called once per frame
		public void Update ()
		{				
				int x = Mathf.RoundToInt (transform.position.x);
				int y = Mathf.RoundToInt (transform.position.y);		
		
				if (x % 2 != 0) {
						x = x - 1;
				}
		
				if (y % 2 != 0) {
						y = y - 1;
				}
		
		
				if (pressedBomb == true && exists == false) {            
						Instantiate (bomb, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);	
						Instantiate (activator, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);
						pressedBomb = false;
						exists = true;							
				}
				if (GameObject.Find ("Activator(Clone)") == null) {
						exists = false;
				}
				anim.SetInteger ("SpeedV", (int)move_y);
				anim.SetInteger ("SpeedH", (int)move_x);
		
				if (move_x < 0 && !isFacingLeft)
						Flip ();
				else if (move_x > 0 && isFacingLeft)
						Flip ();
		}
	
		private void Flip ()
		{	
				isFacingLeft = !isFacingLeft;				
				Vector3 theScale = transform.localScale;				
				theScale.x *= -1;				
				transform.localScale = theScale;
		}
}
