using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBoundDetector: MonoBehaviour {
    private bool gameOver;

    // Use this for initialization
    void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		inBoundCheck();

	}

	private void inBoundCheck() 
	{
		if (transform.position.x > 7f || transform.position.x < -7f || transform.position.y < -10f )
		{
			Destroy(this.gameObject);
			gameOver = true;
		}
	}
}
