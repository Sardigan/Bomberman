using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
		public int power = 5;
		public bool haskey = false;
		
		// Use this for initialization
		void Start ()
		{				
		}

		
	
		// Update is called once per frame
		void Update ()
		{
				if (GameObject.Find ("Player") != null) {
						if (GameObject.Find ("Power") != null) {
								if ((int)GameObject.Find ("Player").transform.position.x == (int)GameObject.Find ("Power").transform.position.x && (int)GameObject.Find ("Player").transform.position.y == (int)GameObject.Find ("Power").transform.position.y) {
										power = 10;
										Destroy (GameObject.Find ("Power"), 2);
								}
						}
				}
				if (GameObject.Find ("Player") != null) {
						if (GameObject.Find ("Key") != null) {
								if ((int)GameObject.Find ("Player").transform.position.x == (int)GameObject.Find ("Key").transform.position.x && (int)GameObject.Find ("Player").transform.position.y == (int)GameObject.Find ("Key").transform.position.y) {
										haskey = true;
										Destroy (GameObject.Find ("Key"), 2);
								}
						}
				}
		}
}

 