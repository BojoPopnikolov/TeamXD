using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leavesriddle : MonoBehaviour
{
    public GameObject RiddleToDestroy;
    public GameObject RiddleToDestroy2;
    public GameObject RiddleToDestroy3;
    public GameObject RiddleToEnable;
    public GameObject TheObjectToCollide;
    public GameObject Player;
    public GameObject CheckIfRiddleActive;

    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject == TheObjectToCollide)
        {
            if (CheckIfRiddleActive.activeSelf == true)
            {


                RiddleToEnable.SetActive(true);
                RiddleToDestroy.SetActive(false);
                RiddleToDestroy2.SetActive(false);
                RiddleToDestroy3.SetActive(false);
            }


        }


    }


}
