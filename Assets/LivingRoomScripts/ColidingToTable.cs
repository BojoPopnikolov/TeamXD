using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidingToTable : MonoBehaviour
{
    public GameObject RiddleToDestroy1;
    public GameObject RiddleToDestroy2;
    public GameObject RiddleToDestroy3;


    public GameObject RiddleToAdd;
    public GameObject Character;
    public GameObject AddKey;
    public GameObject TheObjToColideWith;
    public GameObject CheckIfRiddleActive;

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject == TheObjToColideWith)
        {
            if (CheckIfRiddleActive.activeSelf == true)
            {
                RiddleToAdd.SetActive(true);
                AddKey.SetActive(true);
                RiddleToDestroy1.SetActive(false);
                RiddleToDestroy3.SetActive(false);
                RiddleToDestroy2.SetActive(false);
            }



        }


    }



}
