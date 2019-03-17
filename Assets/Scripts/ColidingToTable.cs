using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidingToTable : MonoBehaviour
{
    public GameObject ObjtoDestroy;
    public GameObject ObjtoDestroy2;
    public GameObject ObjtoDestroy3;
    public GameObject ObjToAdd;
    public GameObject Character;
    public GameObject ObjToAdd2;
    public GameObject TheObj;

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject == TheObj)
        {
            ObjToAdd.SetActive(true);
            ObjToAdd2.SetActive(true);
            ObjtoDestroy.SetActive(false);
            ObjtoDestroy2.SetActive(false);
            ObjtoDestroy3.SetActive(false);



        }


    }



}
