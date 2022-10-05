using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3CloudSpawner : MonoBehaviour {

	// Use this for initialization

	[SerializeField]
	private GameObject[] Clouds;
    private bool level3 =true;

    void Start () {
		StartCoroutine(MovingCloudsRoutine());
	}
	 
	IEnumerator MovingCloudsRoutine() 
	{
		while(level3) 
		{
			Instantiate(Clouds[Random.Range(0,3)] , new Vector3 (-4.5f , Random.Range(0.3f , 4.8f) , 0) , Quaternion.identity);
			yield return new  WaitForSeconds(25f);
			yield return null;
		}
	}
}
