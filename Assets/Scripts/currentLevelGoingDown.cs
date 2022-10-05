using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentLevelGoingDown : MonoBehaviour {



	// Use this for initialization
	IEnumerator goingDown() 
	{
		while (transform.position != new Vector3(0,-10.40f,0))
		{
			transform.position = Vector3.Lerp(transform.position , new Vector3(0,-11,0), Time.deltaTime);
			yield return null;
		}

	}

	public void goDownBitch()
	{
		StartCoroutine(goingDown());
	}
}
