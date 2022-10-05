using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downSideScript : MonoBehaviour {
    public bool whiteBallIsIn;
    public bool colorBallIsIn;

    // Use this for initialization
    void Start () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D other) {
		
			if (other.tag == "Player")
		{
			whiteBallIsIn =true;
			
		}

			if (other.tag == "Saver")
		{
			colorBallIsIn =true;
			
		}
	}
	private void OnTriggerStay2D(Collider2D other) 
	{
		
		if (other.tag == "Player")
		{
		
			
		}
				if (other.tag == "Saver")
		{
		//	colorBallIsIn =true;
			
		}
		
	}
		private void OnTriggerExit2D(Collider2D other) 
	{
		if (other.tag == "Player")
		{
			
			whiteBallIsIn = false;
		}

			if (other.tag == "Saver")
		{
			colorBallIsIn =false;
			
		}
	}
}
