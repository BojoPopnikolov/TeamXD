using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class neshto : MonoBehaviour
{
    public GameObject TheObjectToDestroy;
    public GameObject TheObjectToDestroy2;
    public GameObject TheObjectToDestroy3;
    public GameObject TheObjectToEnable;
    public GameObject TheObject;
    public GameObject Player;
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject == TheObject)
        {
            TheObjectToEnable.SetActive(true);
            TheObjectToDestroy.SetActive(false);
            TheObjectToDestroy2.SetActive(false);
            TheObjectToDestroy3.SetActive(false);



        }
        

    }

   
}



