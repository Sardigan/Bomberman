using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public Controller player;
		public int speed = 5;
		public Transform prefab;

		void Start ()
		{
	
		}

	
		// Update is called once per frame
		void Update ()
		{
				player.Controlling (speed, Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));	
				if (Input.GetKeyDown("space")) {            
            		Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), 
            			Quaternion.identity);
        		}
		    
		}
}