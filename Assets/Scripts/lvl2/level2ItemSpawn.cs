using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2ItemSpawn : MonoBehaviour {

	[SerializeField]
	private GameObject blueFlower;
	[SerializeField]
	private GameObject redFlower;
	[SerializeField]
	private GameObject mop;
	[SerializeField]
	private GameObject number2;
    private bool mrBool= true;
	floorSpawner floorSpawner;


    // Use this for initialization
    void Start () {
		floorSpawner = GameObject.Find("floor1").GetComponent<floorSpawner>();
	}

		IEnumerator spwanRoutine () 
	{
		while(mrBool )
		{
			yield return new WaitForSeconds(8f);
			
			Instantiate(number2 , new Vector3(-2.5f , 4.01f,0), Quaternion.identity);
			yield return new WaitForSeconds(0.5f);
			Instantiate(blueFlower , new Vector3(-0.641f , 2.114f,0), Quaternion.identity);
			yield return new WaitForSeconds(0.5f);
			Instantiate(redFlower , new Vector3(-1.256f , 2.054f,0), Quaternion.identity);
			yield return new WaitForSeconds(0.5f);
		//	Instantiate(mop , new Vector3(2.076f , 3.485f,0), Quaternion.identity);
			//yield return new WaitForSeconds(0.5f);
			floorSpawner.loadMoreBalls();
			
			mrBool =false;
			yield return null;
		}		
	
	}

	public void lvl2Spwan()
	{
		StartCoroutine(spwanRoutine());
	}



	

}
