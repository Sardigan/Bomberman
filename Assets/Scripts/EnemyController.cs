using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
		public Controller enemy;
		private float move_x;
		private float move_y;
		private bool isFacingLeft = true;
		private Animator anim;
		private float t = 0;
		private int tmp = 0;
		
		private int n = 35;
		private int[] b;
		// Use this for initialization
		void Start ()
		{		
				anim = GetComponent<Animator> ();
				move_x = 1;
				move_y = 0;
				t = Time.time;
				b = new int[n]; 
				for (int i = 0; i < n; i++) {
						b [i] = 0;
				}
		}

		void OnCollisionEnter2D (Collision2D col)
		{				
				if (col.gameObject.name == "Player") {
						Destroy (col.gameObject);
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{		

				enemy.Controlling (2, move_x, move_y);	

				RaycastHit2D hitRight;
				RaycastHit2D hitLeft;
				RaycastHit2D hitUp;
				RaycastHit2D hitDown;

				hitRight = Physics2D.Raycast (new Vector2 (transform.position.x + 1.1f, transform.position.y), Vector2.right, 0);
				hitLeft = Physics2D.Raycast (new Vector2 (transform.position.x - 1.1f, transform.position.y), -Vector2.right, 0);
				hitUp = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y + 1.1f), Vector2.up, 0);
				hitDown = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y - 1.1f), -Vector2.up, 0);

		
				if (hitRight.collider != null && hitLeft.collider != null && hitUp.collider != null) {
						move_x = 0;
						move_y = -1;						
				}
				if (hitRight.collider != null && hitLeft.collider != null && hitDown.collider != null) {
						move_x = 0;
						move_y = 1;
				}
				if (hitUp.collider != null && hitDown.collider != null && hitRight.collider != null) {
						move_x = -1;
						move_y = 0;
				}
				if (hitUp.collider != null && hitDown.collider != null && hitLeft.collider != null) {
						move_x = 1;
						move_y = 0;
				}

				
				if (hitRight.collider != null && hitLeft.collider == null && hitUp.collider == null && hitDown.collider == null) {	
						if (move_x == 1 && b [0] == 1) {	
								b [0] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						}
						if (move_y == -1 && b [1] == 1) {
								b [1] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp == 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 7) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						} 
						if (move_y == 1 && b [2] == 1) {
								b [2] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp == 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp > 7) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						} 
				}
				if (hitLeft.collider != null && hitRight.collider == null && hitUp.collider == null && hitDown.collider == null) {	
						if (move_x == -1 && b [3] == 1) {	
								b [3] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						}
						if (move_y == -1 && b [4] == 1) {
								b [4] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp == 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 7) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						} 
						if (move_y == 1 && b [5] == 1) {
								b [5] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp == 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp > 7) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						} 			
				}

				if (hitUp.collider != null && hitRight.collider == null && hitLeft.collider == null && hitDown.collider == null) {	
						if (move_y == 1 && b [6] == 1) {	
								b [6] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						}
						if (move_x == -1 && b [7] == 1) {
								b [7] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp == 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 7) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 
						if (move_x == 1 && b [8] == 1) {
								b [8] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp == 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 7) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 			
				}

				if (hitDown.collider != null && hitRight.collider == null && hitLeft.collider == null && hitUp.collider == null) {
						if (move_y == -1 && b [9] == 1) {	
								b [9] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						}
						if (move_x == -1 && b [10] == 1) {
								b [10] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp == 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 7) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						} 
						if (move_x == 1 && b [11] == 1) {
								b [11] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp == 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 7) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						} 			
				}

				if (hitRight.collider != null && hitUp.collider != null && hitLeft.collider == null && hitDown.collider == null) {
						if (move_x == 1 && b [12] == 1) {
								b [12] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp >= 7) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 
						if (move_y == 1 && b [13] == 1) {
								b [13] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp >= 7) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						}
				}	
				if (hitLeft.collider != null && hitUp.collider != null && hitRight.collider == null && hitDown.collider == null) {
						if (move_x == -1 && b [14] == 1) {
								b [14] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp >= 7) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 
						if (move_y == 1 && b [15] == 1) {
								b [15] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp >= 7) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						}
				}	
				if (hitLeft.collider != null && hitDown.collider != null && hitRight.collider == null && hitUp.collider == null) {
						if (move_x == -1 && b [16] == 1) {
								b [16] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp >= 7) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						} 
						if (move_y == -1 && b [17] == 1) {
								b [17] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp >= 7) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						}
				}
				if (hitRight.collider != null && hitDown.collider != null && hitLeft.collider == null && hitUp.collider == null) {
						if (move_x == 1 && b [18] == 1) {
								b [18] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp >= 7) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						} 
						if (move_y == -1 && b [19] == 1) {
								b [19] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 7) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp >= 7) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						}
				}

				if (hitRight.collider == null && hitLeft.collider == null && hitUp.collider == null && hitDown.collider == null) {
						if (move_x == 1 && b [20] == 1) {
								b [20] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 6) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp == 6) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 
						if (move_x == -1 && b [21] == 1) {
								b [21] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 6) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp == 6) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						}
						if (move_y == 1 && b [22] == 1) {
								b [22] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 6) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp == 6) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						}
						if (move_y == -1 && b [23] == 1) {
								b [23] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 6) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp == 6) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp > 6 && tmp < 9) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp > 8 && tmp < 11) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						}
				}
				if (hitRight.collider != null && hitLeft.collider != null && hitUp.collider == null && hitDown.collider == null) {
						if (move_y == 1 && b [24] == 1) {
								b [24] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 10) {
										move_x = 0;
										move_y = 1;
								}
								if (tmp == 10) {
										move_x = 0;
										move_y = -1;
								}
								t = Time.time;
						} 
						if (move_y == -1 && b [25] == 1) {
								b [25] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 10) {
										move_x = 0;
										move_y = -1;
								}
								if (tmp == 10) {
										move_x = 0;
										move_y = 1;
								}
								t = Time.time;
						}
				}
				if (hitUp.collider != null && hitDown.collider != null && hitRight.collider == null && hitLeft.collider == null) {
						if (move_x == 1 && b [26] == 1) {
								b [26] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 10) {
										move_x = 1;
										move_y = 0;
								}
								if (tmp == 10) {
										move_x = -1;
										move_y = 0;
								}
								t = Time.time;
						} 
						if (move_x == -1 && b [27] == 1) {
								b [27] = 0;
								tmp = Random.Range (1, 11);								
								if (tmp < 10) {
										move_x = -1;
										move_y = 0;
								}
								if (tmp == 10) {
										move_x = 1;
										move_y = 0;
								}
								t = Time.time;
						}
				}

				if (Time.time > t + 1) {
						for (int i = 0; i < n; i++) {
								b [i] = 1;
						}
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
