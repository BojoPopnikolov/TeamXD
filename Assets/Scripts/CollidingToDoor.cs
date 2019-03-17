using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollidingToDoor : MonoBehaviour
{
    public GameObject Character;
    public GameObject Key;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Key)
        {
            SceneManager.LoadScene("TuesDungeon");

        
        }
    }
}




