using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosledenChinRiddle : MonoBehaviour
{
    public GameObject Character;
    public GameObject TheObjectToColideWith;
    public GameObject TheObjectToDestroy;
    public GameObject TheObjectToAdd;
    public GameObject TheObjectToDestroy2;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == TheObjectToColideWith)
        {
            TheObjectToAdd.SetActive(true);
            TheObjectToDestroy.SetActive(false);
            TheObjectToDestroy2.SetActive(false);


        }
    }

}













