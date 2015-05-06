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
		public int move_x = 0;
		public int move_y = 0;
		public bool b = false;
		public bool OnClick = false;

		void Start ()
		{
				anim = GetComponent<Animator> ();
				
		}

		public void Up ()
		{
				move_y = 1;
				OnClick = true;
		}

		public void Down ()
		{
				move_y = -1;
				OnClick = true;
		}

		public void Right ()
		{
				move_x = 1;
				OnClick = true;
		}

		public void Left ()
		{
				move_x = -1;
				OnClick = true;


		}

		public void B ()
		{
				b = true;
		}
		
		void FixedUpdate ()
		{
				if (OnClick == true) {
						player.Controlling (speed, move_x, move_y);
						OnClick = false;
				}
				player.Controlling (speed, (int)Input.GetAxis ("Horizontal"), (int)Input.GetAxis ("Vertical"));
		}

		// Update is called once per frame
		public void Update ()
		{				
				int x = Mathf.RoundToInt (transform.position.x);
				int y = Mathf.RoundToInt (transform.position.y);

				//anim.SetInteger ("SpeedV", (int)Input.GetAxis ("Vertical"));
				//anim.SetInteger ("SpeedH", (int)Input.GetAxis ("Horizontal"));

				//anim.SetInteger ("SpeedH", move_x);
				//anim.SetInteger ("SpeedV", move_y);

		
				if (x % 2 != 0) {
						x = x - 1;
				}

				if (y % 2 != 0) {
						y = y - 1;
				}

			
				if ((Input.GetKeyDown ("space") || b == true) && exists == false) {            
						Instantiate (bomb, new Vector3 (x, y, transform.position.z), 
				             Quaternion.identity);	
						Instantiate (activator, new Vector3 (x, y, transform.position.z), 
			             Quaternion.identity);
						exists = true;	
						b = false;
				}
				if (GameObject.Find ("Activator(Clone)") == null) {
						exists = false;
				}

				if (Input.GetAxis ("Horizontal") < 0 && !isFacingLeft)
						Flip ();
				else if (Input.GetAxis ("Horizontal") > 0 && isFacingLeft)
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