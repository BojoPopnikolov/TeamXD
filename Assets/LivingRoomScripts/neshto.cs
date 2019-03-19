using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class neshto : MonoBehaviour
{
    public GameObject TheRiddleToDestroy;
    public GameObject TheRiddleToDestroy2;
    public GameObject TheRiddleToDestroy3;
    public GameObject TheRiddleToEnable;
    public GameObject TheObjToCollide;
    public GameObject Player;
    public GameObject CheckIfRiddleActive;

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject == TheObjToCollide)
        {
            if(CheckIfRiddleActive.activeSelf == true) {
                TheRiddleToEnable.SetActive(true);
                TheRiddleToDestroy.SetActive(false);
                TheRiddleToDestroy2.SetActive(false);
                TheRiddleToDestroy3.SetActive(false);



            }



        }


    }

   
}



