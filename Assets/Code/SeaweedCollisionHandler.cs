﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaweedCollisionHandler : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Entered");
        //Application.LoadLevel(0);
        SceneManager.LoadScene(0);
    }
}
