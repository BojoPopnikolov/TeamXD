﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchingTheKey : MonoBehaviour
{

    public GameObject Character;
    public GameObject Key;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == Key)
        {
            SceneManager.LoadScene("EndGame");




        }


    }
    }


