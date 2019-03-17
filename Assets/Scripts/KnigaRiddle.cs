using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnigaRiddle : MonoBehaviour
{
    public GameObject Character;
    public GameObject TheObjectToColideWith;
    public GameObject TheObjectToDestroy;
    public GameObject TheObjectToAdd;
    public GameObject TheObjectToAdd2;
    public GameObject TheObjectToDestroy2;
    public GameObject TheObjectToDestroy3;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == TheObjectToColideWith)
        {
            TheObjectToAdd.SetActive(true);
            TheObjectToAdd2.SetActive(true);
            TheObjectToDestroy.SetActive(false);
            TheObjectToDestroy2.SetActive(false);
            TheObjectToDestroy3.SetActive(false);



        }
    }
}
