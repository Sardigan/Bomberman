using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
		
		public string name_level;

		public void LoadLevel ()
		{
				Application.LoadLevel (name_level);

		}

		void OnGUI ()
		{			
				//GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 300), "Menu");              
		
				/*if (GUI.Button (new Rect (Screen.width / 2 - 140, Screen.height / 2 - 170, 280, 80), "New game")) { 
						Application.LoadLevel (name_level);             
				}
				if (GUI.Button (new Rect (Screen.width / 2 - 140, Screen.height / 2 - 85, 280, 80), "Options")) {  
								
				}
		
				if (GUI.Button (new Rect (Screen.width / 2 - 140, Screen.height / 2 - 0, 280, 80), "Exit")) {    		
						Application.Quit ();                    
				}*/
		}
}