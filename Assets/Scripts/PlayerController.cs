using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public Controller player;	
	public int speed = 5;
		void Start ()
		{
	
		}

	
		// Update is called once per frame
		void Update ()
		{
 			player.Controlling(speed, Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));	
		    
		}
}
