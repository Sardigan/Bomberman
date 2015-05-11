using UnityEngine;
using System.Collections;

public class Objects : MonoBehaviour
{
		public int power = 5;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GameObject.Find ("Power") != null) {
						if ((int)GameObject.Find ("Player").transform.position.x == (int)GameObject.Find ("Power").transform.position.x && (int)GameObject.Find ("Player").transform.position.y == (int)GameObject.Find ("Power").transform.position.y) {
								power = 10;
								Destroy (GameObject.Find ("Power"), 3);
						}
				}
		}
}

 