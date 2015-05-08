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
		private bool pressed = false;
		private bool pressedUp = false;
		private bool pressedDown = false;
		private bool pressedRight = false;
		private bool pressedLeft = false;
		public float move_x = 0;
		public float move_y = 0;
	
		void Start ()
		{
				anim = GetComponent<Animator> ();
		
		}

		public void SetUpBomb ()
		{
				pressed = true;
		}

		public void Up ()
		{
				pressedUp = true;
				move_x = 0;
				move_y = 1;
		}

		public void Down ()
		{
				pressedDown = true;
				move_x = 0;
				move_y = -1;
		}

		public void Right ()
		{
				pressedRight = true;
				move_x = 1;
				move_y = 0;
		}

		public void Left ()
		{
				pressedLeft = true;
				move_x = -1;
				move_y = 0;
		}
	
		void FixedUpdate ()
		{
				if (pressedUp == true || pressedDown == true || pressedRight == true || pressedLeft == true) {
						player.Controlling (speed, move_x, move_y);
						pressedUp = false;
						pressedDown = false;
						pressedRight = false;
						pressedLeft = false;
			anim.SetInteger ("SpeedV", (int)move_y);
			anim.SetInteger ("SpeedH", (int)move_x);
				}
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
		
		
				if (pressed == true && exists == false) {            
						Instantiate (bomb, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);	
						Instantiate (activator, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);
						pressed = false;
						exists = true;							
				}
				if (GameObject.Find ("Activator(Clone)") == null) {
						exists = false;
				}
		
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
