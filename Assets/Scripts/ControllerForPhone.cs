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
		public float move_x;
		public float move_y;
		public bool haskey = false;
		public int power;
	
		void Start ()
		{
				anim = GetComponent<Animator> ();
				speed = PlayerPrefs.GetFloat ("speedPlayer", speed); 
				power = PlayerPrefs.GetInt ("power", power);
		
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

		void OnTriggerEnter2D (Collider2D coll)
		{
				if (coll.gameObject.tag == "Key") {
						haskey = true;
						Destroy (coll.gameObject);
				} 
				if (coll.gameObject.tag == "Power") {
						power += 5;
						Destroy (coll.gameObject);
				}
				if (coll.gameObject.tag == "Door" && haskey == true) {
						Application.LoadLevel ("First");

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
