using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
	public bool hasDungeonKey= false;
	public string weaponType= "Arcane Staff";
    // Start is called before the first frame update
    public Transform camTransform;

	public GameObject directionLight;

    void Start()
    {
        if(!hasDungeonKey)
        	Debug.Log("You may not enter the sacred key");
        if( weaponType != "Longsword")
        	Debug.Log("You don't appear to have the right type");


        //directionLight = GameObject.Find("Doska_Prozrachnaua (1)");
        camTransform= directionLight.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComputeAge(int Qwerty)
    {

    }
}
