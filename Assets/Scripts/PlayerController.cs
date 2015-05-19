using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public Controller player;
		public float speed;
		public Transform bomb;
		private bool exists = false;
		private Animator anim;
		private bool isFacingLeft = true;
		public Transform activator;

		void Start ()
		{
				anim = GetComponent<Animator> ();
				speed = PlayerPrefs.GetFloat ("speedPlayer", speed);
				
		}
		
		void FixedUpdate ()
		{
				
				player.Controlling (speed, Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));				

		}
		

		// Update is called once per frame
		public void Update ()
		{				
				int x = Mathf.RoundToInt (transform.position.x);
				int y = Mathf.RoundToInt (transform.position.y);

				
				anim.SetInteger ("SpeedV", (int)Input.GetAxis ("Vertical"));
				anim.SetInteger ("SpeedH", (int)Input.GetAxis ("Horizontal"));

				if (Input.GetAxis ("Horizontal") < 0 && !isFacingLeft)
						Flip ();
				else if (Input.GetAxis ("Horizontal") > 0 && isFacingLeft)
						Flip ();
				

		
				if (x % 2 != 0) {
						x = x - 1;
				}

				if (y % 2 != 0) {
						y = y - 1;
				}

			
				if (Input.GetKeyDown ("space") && exists == false) {            
						Instantiate (bomb, new Vector3 (x, y, transform.position.z), 
				             Quaternion.identity);	
						Instantiate (activator, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);
						exists = true;							
				}
				if (GameObject.Find ("Activator(Clone)") == null) {
						exists = false;
				}

				
		}

		private void Flip ()
		{	
				isFacingLeft = !isFacingLeft;				
				Vector3 theScale = transform.localScale;				
				theScale.x *= -1;				
				transform.localScale = theScale;
		}	
		
}