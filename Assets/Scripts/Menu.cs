using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
		
		public string name_level;

		public void LoadLevel ()
		{
				Application.LoadLevel (name_level);
		}

		public void Settings ()
		{
				Application.LoadLevel ("Settings");
		}
		
		public void Quit ()
		{
				Application.Quit ();
		}

		public void LoadMenu ()
		{
				Application.LoadLevel ("Menu");
		}
		
}