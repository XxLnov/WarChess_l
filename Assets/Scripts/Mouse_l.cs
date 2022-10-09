using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_l : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Sfera;
    private bool Selected;
    private Transform Privios;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
       // Debug.DrawRay(transform.position, transform.forward*100f, Color.yellow);
        
        if (MatOdinHod(ray, "Tyra_l", "Kletka", "Partiua" ))
            Okteviryem();

        if (MatOdinHod(ray, "Tyra_l", "Kletka_l", "Partiua (3)" ))
            Destroy(GameObject.Find("Doska"));

        if ( MatOdinHod(ray, "Tyra_l", "Kletka_ll", "Partiua (4)" ))
            Destroy(GameObject.Find("Doska (1)"));

    }
    bool inList(string name )
    {
        string []Listok = {"Tyra_l", "King_l", "Tyra_l (1)"};
        foreach (string n in Listok)
        {
            if ( n == name)
                return true;
        }
        return false;
    }
    bool MatOdinHod(Ray ray, string sFigyra, string Kletka, string destroy)
    {
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            //Sfera.position= hit.point;
            if (Input.GetMouseButtonDown(0) && inList( hit.collider.gameObject.name ) )
            {   
                if ( Selected == false)
                {
                     Debug.Log( "Selected" );
                    Privios= hit.collider.gameObject.GetComponent<Transform>();
                    hit.collider.gameObject.GetComponent<Transform>().localScale= hit.collider.gameObject.GetComponent<Transform>().localScale*2;
                    Selected= true;
                    Debug.Log( sFigyra );
                }


            }
            if (hit.collider.gameObject.name== Kletka && Input.GetMouseButtonDown(0) && Privios.name==sFigyra)
            {
                Debug.Log( "destroy" );
                Selected= false;
                Destroy(GameObject.Find(destroy));
                return true;

            }
            if( Selected && Input.GetMouseButtonDown(0) && !inList( hit.collider.gameObject.name )){
                Privios.localScale= Privios.localScale/2f;
                Selected= false;
                }
        } 
        return false;
    }
    void Okteviryem()
    {
        GameObject.Find("Pivot").GetComponent<Open>().Otrivaem= true;
        GameObject.Find("Pivot_l").GetComponent<Open>().Otrivaem= true;
        GameObject.Find("Shape017").GetComponent<Door>().Zakritie= true;
    }

}
