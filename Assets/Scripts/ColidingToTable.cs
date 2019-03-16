using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidingToTable : MonoBehaviour
{
    public GameObject ObjtoDestroy;
    public GameObject ObjToAdd;
    public GameObject Character;
    public GameObject ObjToAdd2;
    public GameObject TheObj;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == TheObj)
        {
            ObjToAdd.SetActive(true);
            ObjToAdd2.SetActive(true);
            ObjtoDestroy.SetActive(false);



        }


    }



}
