using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotLineDetector : MonoBehaviour {
	//can get modified by collison detector in color ball
	public bool canPass = false;
	
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player" && other.transform.position.y > 0.38f)
		{
			if (canPass)
			{
				canPass =false;
			}else
			{
				Destroy(other.gameObject);
			}
			
			
		}
	}
}
