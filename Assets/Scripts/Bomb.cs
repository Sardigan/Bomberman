using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		private float tm = 0;
		private bool b = true; 
		// Use this for initialization
		void Start ()
		{
				tm = (int)Time.time + 2;
		}

		// Update is called once per frame
		void Update ()
		{
				if ((int)Time.time == tm && b == true) {						
						gameObject.AddComponent ("SphereCollider");	
						b = false;
				}
				
				Destroy (gameObject, 10);
				Debug.Log (Time.time);
				
		}

}
