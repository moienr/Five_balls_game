using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3EndAnimations : MonoBehaviour {

	public Animator animator;
	//public Animator grassAnimator;

	// Use this for initialization
	void Start () {
		
	}


	public void endingCalls()
	{
	animator.SetBool("buildingDown" ,true);
//		grassAnimator.SetBool("grassDown" , true);
	}
	
	//public void  
}
