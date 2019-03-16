using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollidingToDoor : MonoBehaviour
{
    public GameObject Character;
    public GameObject Door;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Character)
        {
            SceneManager.LoadScene("");

        
        }
    }
}




