﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name.Contains("Platform"))
        {

            Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        } else
            {
                GameObject.Find("DoodleHead").SetActive(false);
                gameOverCanvas.SetActive(true);
        }
       }
}
