using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
		private float tm = 0;
		// Use this for initialization
		void Start ()
		{
			tm = Time.time;
		}

		void Sa () {
			if (Time.time > tm)
				{					
					tm = Time.time + 10;
					gameObject.AddComponent("SphereCollider");					
				}
		}

		// Update is called once per frame
		void Update ()
		{
			
		}
}
