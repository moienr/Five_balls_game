using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {
	HingeJoint2D hinge;
	private bool open = true;
	private bool close = true;

	// Use this for initialization
	void Start () {
		hinge = this.GetComponent<HingeJoint2D>();
		hinge.useMotor = false;
	}
	
	// Update is called once per frame

	
	IEnumerator openDoor() 
	{
		while(open)
		{
			JointMotor2D motor = hinge.motor;
			hinge.useMotor = true;
			motor.motorSpeed =-100;
			open =false;
			yield return null;
			
			
		}
		
	}
	IEnumerator closeDoor() 
	{
		while(close)
		{
			JointMotor2D motor = hinge.motor;
			hinge.useMotor = true;
			motor.motorSpeed =10;
			close =false;
			yield return null;
			
		}
		
	}

	public void openCall() 
		{
			StartCoroutine(openDoor());
		}
	public void closeCall() 
		{
			StartCoroutine(closeDoor());
		}
}
