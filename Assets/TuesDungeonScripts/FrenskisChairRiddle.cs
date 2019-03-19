using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenskisChairRiddle : MonoBehaviour
{
    public GameObject Character;
    public GameObject TheObjectToColideWith;
    public GameObject TheRiddleToAdd;
    public GameObject TheRiddleToDestroy2;
    public GameObject TheRiddleToDestroy3;
    public GameObject TheRiddleToDestroy;
    public GameObject CheckIfRiddleActive;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == TheObjectToColideWith)
        {   if (CheckIfRiddleActive.activeSelf == true)
            {
                TheRiddleToAdd.SetActive(true);

                TheRiddleToDestroy.SetActive(false);
                TheRiddleToDestroy2.SetActive(false);
                TheRiddleToDestroy3.SetActive(false);
            }


        }
    }

    }



