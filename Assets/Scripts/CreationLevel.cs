using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreationLevel : MonoBehaviour
{
		public bool exists = false;
		public GameObject block;
		public GameObject ground;
		public GameObject enemy;
		public GameObject box;
		public GameObject key;
		public GameObject door;
		public GameObject power;
		public GameObject[] boxes;
		public List<Vector3> emptypos = new List<Vector3> ();
		public List<Vector3> notemptypos = new List<Vector3> ();
		public int tmp;
		public int count;
		public int k = 0;
		public bool existskey = false;
		public Random random ;


		// Use this for initialization
		void Start ()
		{	
				count = Random.Range (6, 10);				
				
		}

		public void LoadMenu ()
		{
				Application.LoadLevel ("Menu");
		}
	
		void CreationBlocks ()
		{
				for (float x = -14; x <= 14; x+=2) {						
						for (float y = -12; y <= 12; y+=2) {
								if (x == -14 || x == 14)
										Instantiate (block, new Vector3 (x, y, -1), Quaternion.identity);
								if (y == -12 || y == 12)
										Instantiate (block, new Vector3 (x, y, -1), Quaternion.identity);
						}
				}
				
				for (float x = -10; x <= 10; x+=4) {
						for (float y = -8; y <= 8; y+=4) {
								Instantiate (block, new Vector3 (x, y, -1), Quaternion.identity);
						}
				}
				
		}

		void CreationBoxes ()
		{				
				for (float x = -12; x <= 12; x+=2) {
						for (float y = -10; y <= 10; y+=2) {
								if (x == -12 && y == 10 || x == -12 && y == 8 || x == -10 && y == 10)
										continue;
								if (x % 4 == 0) {
										tmp = Random.Range (0, 2);
										if (tmp == 1) {												
												Instantiate (box, new Vector3 (x, y, -1), Quaternion.identity);
												notemptypos.Add (new Vector3 (x, y, -0.5f));
										} else
												emptypos.Add (new Vector3 (x, y, -1));
								}																										
						}
				}

				for (float x = -12; x <= 12; x+=2) {
						for (float y = -10; y <= 10; y+=2) {
								if (x == -12 && y == 10 || x == -12 && y == 8 || x == -10 && y == 10)
										continue;
								if (y % 4 != 0) {
										tmp = Random.Range (0, 2);
										if (tmp == 1) {												
												Instantiate (box, new Vector3 (x, y, -1), Quaternion.identity);
												notemptypos.Add (new Vector3 (x, y, -0.5f));
										} else
												emptypos.Add (new Vector3 (x, y, -1));
								}								
						}
				}
		}

		void CreationObjects ()
		{
				
				Vector3 poskey = notemptypos [Random.Range (0, notemptypos.Count)];
				Instantiate (key, poskey, Quaternion.identity);
				notemptypos.Remove (poskey);

				Vector3 posdoor = notemptypos [Random.Range (0, notemptypos.Count)];
				Instantiate (door, posdoor, Quaternion.identity);
				notemptypos.Remove (posdoor);

				Vector3 pospower = notemptypos [Random.Range (0, notemptypos.Count)];
				Instantiate (power, pospower, Quaternion.identity);
				notemptypos.Remove (pospower);
				
		}

		void CreationEnemies ()
		{		
				for (int i = 0; i < count; i++) {
						Vector3 pos = emptypos [Random.Range (0, emptypos.Count)];
						Instantiate (enemy, pos, Quaternion.identity);
				}
		}

		void CreationGround ()
		{

				Instantiate (ground, new Vector3 (0, 0, 0), Quaternion.identity);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (exists == false) {
						CreationBlocks ();
						CreationGround ();
						CreationBoxes ();
						CreationObjects ();
						CreationEnemies ();
						exists = true;	
						
				}
		}
}
