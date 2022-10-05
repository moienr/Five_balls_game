using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uperSideScript : MonoBehaviour {
    public bool whiteBallIsIn;
    public bool virginPlayer =true;
	[SerializeField]
	private bool localBallIsUnder =true;
	


    // Use this for initialization
    void Start () {
		
	}
	private void OnTriggerEnter2D(Collider2D other) {
		
			if (other.tag == "Player")
		{
			whiteBallIsIn =true;
			
		}
	}
	private void OnTriggerStay2D(Collider2D other) 
	{
		
		if (other.tag == "Player")
		{
			whiteBallScript whiteBall = GameObject.Find(other.name).GetComponent<whiteBallScript>();
			whiteBall.ballIsUnder=false;
			localBallIsUnder = false;
			
		}
	}
		private void OnTriggerExit2D(Collider2D other) 
	{
		if (other.tag == "Player")
		{
			whiteBallScript whiteBall = GameObject.Find(other.name).GetComponent<whiteBallScript>();
			whiteBall.ballIsUnder=true;
			localBallIsUnder = true;
			whiteBallIsIn = false;
			//player is out for the first time and it can not be moved in the uper side
			virginPlayer = false;
		}
	}
}
