using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
		public Controller enemy;
		private float move_x;
		private float move_y;
		//private bool b = false;
		private float t = 0;
		private int tmp = 0;
		private int x;
		private int y;
		private int n = 35;
		private int[] b1;
		// Use this for initialization
		void Start ()
		{
				move_x = 0;
				move_y = 0;
				t = Time.time;
				b1 = new int[n]; 
				for (int i = 0; i < n; i++) {
						b1 [i] = 0;
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
				RaycastHit2D hit1;
				RaycastHit2D hit2;
				RaycastHit2D hit3;
				RaycastHit2D hit4;

				hit1 = Physics2D.Raycast (new Vector2 (transform.position.x + 1.2f, transform.position.y), Vector2.right, 0);
				hit2 = Physics2D.Raycast (new Vector2 (transform.position.x - 1.2f, transform.position.y), -Vector2.right, 0);
				hit3 = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y + 1.2f), Vector2.up, 0);
				hit4 = Physics2D.Raycast (new Vector2 (transform.position.x, transform.position.y - 1.2f), -Vector2.up, 0);

		
				if (hit1.collider != null && hit2.collider != null && hit3.collider != null) {
						move_x = 0;
						move_y = -1;						
				}
				if (hit1.collider != null && hit2.collider != null && hit4.collider != null) {
						move_x = 0;
						move_y = 1;
				}
				if (hit3.collider != null && hit4.collider != null && hit1.collider != null) {
						move_x = -1;
						move_y = 0;
				}
				if (hit3.collider != null && hit4.collider != null && hit2.collider != null) {
						move_x = 1;
						move_y = 0;
				}

				
				if (hit1.collider != null && hit2.collider == null && hit3.collider == null && hit4.collider == null) {	
						if (move_x == 1 && b1 [0] == 1) {	
								b1 [0] = 0;
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
						if (move_y == -1 && b1 [1] == 1) {
								b1 [1] = 0;
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
						if (move_y == 1 && b1 [2] == 1) {
								b1 [2] = 0;
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
				if (hit2.collider != null && hit1.collider == null && hit3.collider == null && hit4.collider == null) {	
						if (move_x == -1 && b1 [3] == 1) {	
								b1 [3] = 0;
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
						if (move_y == -1 && b1 [4] == 1) {
								b1 [4] = 0;
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
						if (move_y == 1 && b1 [5] == 1) {
								b1 [5] = 0;
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

				if (hit3.collider != null && hit1.collider == null && hit2.collider == null && hit4.collider == null) {	
						if (move_y == 1 && b1 [6] == 1) {	
								b1 [6] = 0;
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
						if (move_x == -1 && b1 [7] == 1) {
								b1 [7] = 0;
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
						if (move_x == 1 && b1 [8] == 1) {
								b1 [8] = 0;
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

				if (hit4.collider != null && hit1.collider == null && hit2.collider == null && hit3.collider == null) {	
						if (move_y == -1 && b1 [9] == 1) {	
								b1 [9] = 0;
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
						if (move_x == -1 && b1 [10] == 1) {
								b1 [10] = 0;
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
						if (move_x == 1 && b1 [11] == 1) {
								b1 [11] = 0;
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

				if (hit1.collider != null && hit3.collider != null && hit2.collider == null && hit4.collider == null) {
						if (move_x == 1 && b1 [12] == 1) {
								b1 [12] = 0;
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
						if (move_y == 1 && b1 [13] == 1) {
								b1 [13] = 0;
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
				if (hit2.collider != null && hit3.collider != null && hit1.collider == null && hit4.collider == null) {
						if (move_x == -1 && b1 [14] == 1) {
								b1 [14] = 0;
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
						if (move_y == 1 && b1 [15] == 1) {
								b1 [15] = 0;
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
				if (hit2.collider != null && hit4.collider != null && hit1.collider == null && hit3.collider == null) {
						if (move_x == -1 && b1 [16] == 1) {
								b1 [16] = 0;
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
						if (move_y == -1 && b1 [17] == 1) {
								b1 [17] = 0;
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
				if (hit1.collider != null && hit4.collider != null && hit2.collider == null && hit3.collider == null) {
						if (move_x == 1 && b1 [18] == 1) {
								b1 [18] = 0;
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
						if (move_y == -1 && b1 [19] == 1) {
								b1 [19] = 0;
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

				if (hit1.collider == null && hit2.collider == null && hit3.collider == null && hit4.collider == null) {
						if (move_x == 1 && b1 [20] == 1) {
								b1 [20] = 0;
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
						if (move_x == -1 && b1 [21] == 1) {
								b1 [21] = 0;
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
						if (move_y == 1 && b1 [22] == 1) {
								b1 [22] = 0;
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
						if (move_y == -1 && b1 [23] == 1) {
								b1 [23] = 0;
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
				if (hit1.collider != null && hit2.collider != null && hit3.collider == null && hit4.collider == null) {
						if (move_y == 1 && b1 [24] == 1) {
								b1 [24] = 0;
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
						if (move_y == -1 && b1 [25] == 1) {
								b1 [25] = 0;
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
				if (hit3.collider != null && hit4.collider != null && hit1.collider == null && hit2.collider == null) {
						if (move_x == 1 && b1 [26] == 1) {
								b1 [26] = 0;
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
						if (move_x == -1 && b1 [27] == 1) {
								b1 [27] = 0;
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
								b1 [i] = 1;
						}
				}
				
				enemy.Controlling (2, move_x, move_y);
		 
				
		}
}
