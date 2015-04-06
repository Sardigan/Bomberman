using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{

		public string name_level;
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
		}
}
