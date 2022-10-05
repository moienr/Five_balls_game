using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {
    private const float _howHighShouldColorBallBeToIntract = -0.33f;
    private int remainingBalls;
	private dotLineDetector dotLine;
	private GameManager gameManager;

    public int PlayerPoint ;
    private uperSideScript uperSide;


    // Use this for initialization
    void Start () {
		dotLine = GameObject.Find("dotLine").GetComponent<dotLineDetector>();
		gameManager =GameObject.Find("GameManager").GetComponent<GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	private void OnCollisionEnter2D(Collision2D other) 
	{
	if (gameManager.twoFinger ==false)
	{

		if (transform.position.y > _howHighShouldColorBallBeToIntract)
		{
			if (other.transform.tag =="Player")
			{
				uperSide = GameObject.Find("uperSide").GetComponent<uperSideScript>();
				if (uperSide.whiteBallIsIn)
				{
					Destroy(this.gameObject);
					PlayerPoint ++;
					gameManager.Points ++;
					

				}
				
			
				if(dotLine != null)
				{
					dotLine.canPass = true;
				}

			}
		}

	}


	if (gameManager.twoFinger)
	{

		if (transform.position.y > _howHighShouldColorBallBeToIntract)
		{
			if (other.transform.tag =="Player")
			{
				uperSide = GameObject.Find("uperSide").GetComponent<uperSideScript>();
				if (uperSide.whiteBallIsIn)
				{
					Destroy(this.gameObject);
					PlayerPoint ++;
					gameManager.Points ++;
					

				}
				
			//if the point is even it means at least two balls where collided with the white ball
				if(dotLine != null && PlayerPoint % 2 ==0)
				{
					dotLine.canPass = true;
				}

			}
		}

	}

	}
}
