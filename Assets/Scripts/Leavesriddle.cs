using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leavesriddle : MonoBehaviour
{
    public GameObject TheObjectToDestroy;
    public GameObject TheObjectToDestroy2;
    public GameObject TheObjectToEnable;
    public GameObject TheObject;
    public GameObject Player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == TheObject)
        {
            TheObjectToEnable.SetActive(true);
            TheObjectToDestroy2.SetActive(false);



        }


    }

    void OnCollisionExit2D(Collision2D collisionex)
    {
        if (collisionex.gameObject == TheObject)
        {

            TheObjectToDestroy.SetActive(false);
        }
    }
}
