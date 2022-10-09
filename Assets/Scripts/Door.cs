using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	public bool Zakritie;
    // Start is called before the first frame update
    public  AudioSource AS;
    //public  AudioClip AC;
	public Vector3 myVector ;
	public float VremuaZakritiua;
    void Start()
    {
		//AS= GetComponent<AudioSource>() ;
	}

    // Update is called once per frame
    void Update()
    {
        	if (Zakritie)
        	{
        		//Transform door= transform;
        		//AS.PlayOneShot(AC, 0.01f);

				AS.mute= false;
        		//Vector3 myVector = new Vector3(0.0021f, 0.03f, 1.176f );
        		if (myVector== transform.localPosition)
        		{
        			AS.mute= true;
        			Destroy(GameObject.Find("Enemy"));
        			Destroy(GameObject.Find("Enemy  (1)"));
        			Destroy(GameObject.Find("Enemy  (2)"));
        		}
        		transform.localPosition= Vector3.MoveTowards( transform.localPosition, myVector , Time.deltaTime* VremuaZakritiua );
        	}
    }
}
