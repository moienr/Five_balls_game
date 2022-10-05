using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2BackGround : MonoBehaviour {


	whiteBallLoading whiteBallLoading;
	
	// Use this for initialization
	void Start () {
	whiteBallLoading = GameObject.Find("whiteBall").GetComponent<whiteBallLoading>();
	}

	


	IEnumerator ScaleRoutine () 
	{

		whiteBallLoading.whiteBallBiggerLevelChangeCall();
		yield return new WaitForSeconds(3f);

		while(transform.localScale.x > 0.435f || transform.position.x >0)
		{
			
			transform.position = Vector3.Lerp(transform.position , new Vector3(-0.01f,0,0) , Time.deltaTime );
			transform.localScale =Vector3.Lerp(transform.localScale , new Vector3(0.433f,0.433f,1) ,Time.deltaTime );
			yield return null;
		}

		
		
	}


	public void StartRoutine() 
	{

		
		StartCoroutine(ScaleRoutine());
		if (whiteBallLoading != null)
		{
			whiteBallLoading.whiteBallSmallerLevelChangeCall();
		}
	

	
	}

}
