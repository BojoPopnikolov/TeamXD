using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosledenChinRiddle : MonoBehaviour
{
    public GameObject Character;
    public GameObject TheObjectToColideWith;
    public GameObject TheObjectToDestroy;
    public GameObject TheObjectToAdd;
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject == TheObjectToColideWith)
        {
            TheObjectToAdd.SetActive(true);
            TheObjectToDestroy.SetActive(false);


        }
    }
    
    void OnCollisionExit2D(Collision2D colex)
            {
        if (colex.gameObject == TheObjectToColideWith)
                {
            TheObjectToAdd.SetActive(false);
            


    }

            }


        }










