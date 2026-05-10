using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class birdscrpit : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float strength;
    public logic Logic;
    public bool birdising = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("lg").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && birdising) {
            myrigidbody.linearVelocity = Vector2.up * strength;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("start");
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        
            Logic.gameover();
            birdising = false;
        
    }
}
