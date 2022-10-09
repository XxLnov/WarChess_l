using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oryjie : MonoBehaviour
{
    // Start is called before the first frame update
    public   GameObject Blaster;
    private   PlayerBehavior PlayerB;
    void Start()
    {
        
    }
	void OnTriggerEnter(Collider other)
	{
	//2
		if(other.name == "Player")
		{
			Debug.Log("OnTriggerEnter");
			PlayerB= GameObject.Find("Player").GetComponent<PlayerBehavior>();
			PlayerB.Strelba= true;
			Blaster.SetActive(true);
			Destroy(this.gameObject);
			
		}
	}
    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 0, 2 , 0 );
    }
}
