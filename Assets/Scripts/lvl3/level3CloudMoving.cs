using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3CloudMoving : MonoBehaviour {

	[SerializeField]
	private float speed;
	[SerializeField]
    private float cloadGoingRightLimit;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3(transform.position.x + speed , transform.position.y , transform.position.z);
		if (transform.position.x >cloadGoingRightLimit)
			{
				Destroy(this.gameObject);
			}
	}
}
