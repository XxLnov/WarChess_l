using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
	public GameBehavior gameManager;
	private GameObject Dver;
	private int Zaderjka;
	private bool Ydar;
	void Start()
	{
	// 2
	gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
	}
	void OnCollisionEnter(Collision collision)
	{
	// 2
		Debug.Log("TYT");
		if(collision.gameObject.name == "Player")
		{
		// 3
			Ydar= true;
			
			Destroy(this.transform.parent.gameObject);
			Dver= GameObject.Find("Shape017");
			Dver.GetComponent<Door>().Zakritie= true;
			// 4
			Debug.Log("Item collected!");
			gameManager.Items += 1;
		}
	}
	void FixedUpdate()
	{
		if(Zaderjka==300){
			Destroy(this.transform.parent.gameObject);
			Zaderjka= 0;
			Ydar= false;
		}
		if(Ydar){

			Zaderjka++;
		}
	}

}
