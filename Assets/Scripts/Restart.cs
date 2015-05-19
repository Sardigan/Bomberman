using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{

		public string name_level;
		public string name_level1;
		private int t;
		private bool isPlayerLive = true;		

		// Use this for initialization
		void Start ()
		{
					
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GameObject.Find ("Player") == null && isPlayerLive == true) {
						t = (int)Time.time + 3;
						isPlayerLive = false;						
				}
				if (isPlayerLive == false && Time.time > t) {
						Application.LoadLevel (name_level);
				}
		if (GameObject.Find ("Main Camera").GetComponent<Objects> ().haskey == true && 
		    (int)GameObject.Find ("Player").transform.position.x == (int)GameObject.Find ("Door").transform.position.x && 
		    (int)GameObject.Find ("Player").transform.position.y == (int)GameObject.Find ("Door").transform.position.y) {
						Application.LoadLevel (name_level1);									
				}
		}
}
