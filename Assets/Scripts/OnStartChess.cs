using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartChess : MonoBehaviour
{
    // Start is called before the first frame update
	private bool Q;
	private bool Step2;
	private Collider Other;
	private Transform Point;
	private Transform Point_l;
	private Transform Point_ll;
	private Transform Player;
	private Transform O1;
	private Transform O2;
	public GameObject Peshka;
 	void OnTriggerEnter(Collider other)
	{
	//2
		if(other.name == "Player")
		{
			Debug.Log("Stop!");
			PlayerMove playerMove= other.GetComponent<PlayerMove>() ;  
			PlayerBehavior payerBehavior= other.GetComponent<PlayerBehavior>()  ; 
			playerMove.enabled= false;
			payerBehavior.enabled= false;
			Q= true;
			Other= other;

			GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic= true;
			//other.GetComponent<Transform>().position= GameObject.Find("Point").GetComponent<Transform>().position;
		}
	}
	    void Start()
    {
        Player= GameObject.Find("Player").GetComponent<Transform>();
		Point= GameObject.Find("Point").GetComponent<Transform>();
		Point_l= GameObject.Find("Point_l").GetComponent<Transform>();
		Point_ll= GameObject.Find("Point_ll").GetComponent<Transform>();
    }
	void Update()
	{
		if (Q){
		Player.position = Vector3.MoveTowards( Player.position, Point.position, Time.deltaTime*1f );
		}
		if (Player.position==Point.position && Step2==false){
			GameObject.Find("Camera").GetComponent<Camera>().enabled= true;
			Debug.Log("TYT");
			Step2= true; 
			Instantiate(Peshka, Player.position, Player.rotation).name= "O1";
			Instantiate(Peshka, Player.position, Player.rotation).name= "O2";

			O1= GameObject.Find("O1").GetComponent<Transform>();
			O2= GameObject.Find("O2").GetComponent<Transform>();
			
		}
		if (Step2)
		{
			Player.GetComponent<Renderer>().enabled= false;
			O2.position = Vector3.MoveTowards( O2.position, Point_l.position, Time.deltaTime*1f );
			O1.position = Vector3.MoveTowards( O1.position, Point_ll.position, Time.deltaTime*1f );
		}
	}
}
