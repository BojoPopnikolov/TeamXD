using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnigaRiddle : MonoBehaviour
{
    public GameObject Character;
    public GameObject TheObjectToColideWith;
   
    public GameObject TheRiddleToAdd;
    public GameObject AddKey;
    public GameObject TheRiddleToDestroy;
    public GameObject TheRiddleToDestroy2;
    public GameObject TheRiddleToDestroy3;
    public GameObject CheckIfRiddleActive;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == TheObjectToColideWith)
        {
            if (CheckIfRiddleActive.activeSelf == true)
            {
                TheRiddleToAdd.SetActive(true);
                AddKey.SetActive(true);

                TheRiddleToDestroy.SetActive(false);
                TheRiddleToDestroy3.SetActive(false);
                TheRiddleToDestroy2.SetActive(false);
            }



        }
    }
}
