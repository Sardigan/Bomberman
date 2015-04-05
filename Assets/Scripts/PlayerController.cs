using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public Controller player;
		public float speed;
		public Transform bomb;
		private bool exists = false;
		private Animator anim;
		private bool isFacingRight = true;

		void Start ()
		{
				anim = GetComponent<Animator> ();	
		}

		
		// Update is called once per frame
		void Update ()
		{					
				player.Controlling (speed, Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
				int x = Mathf.RoundToInt (transform.position.x);
				int y = Mathf.RoundToInt (transform.position.y);

				anim.SetInteger ("SpeedV", (int)Input.GetAxis ("Vertical"));
				anim.SetInteger ("SpeedH", (int)Input.GetAxis ("Horizontal"));
		
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
				if (Input.GetAxis ("Horizontal") < 0 && !isFacingRight)
						Flip ();
				else if (Input.GetAxis ("Horizontal") > 0 && isFacingRight)
						Flip ();
		}

		private void Flip ()
		{
	
				isFacingRight = !isFacingRight;				
				Vector3 theScale = transform.localScale;				
				theScale.x *= -1;				
				transform.localScale = theScale;
		}	
		
}