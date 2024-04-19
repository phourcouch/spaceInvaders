using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    public static bool freezeGame;
    public GameObject gameOver;
    public GameObject youWin;
    public static float top;
    public static float bottom;
    public static float left;
    public static float right;
    public Transform spaceInvaderPrefab;
    public static int numInvaders = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.GetComponent<SpriteRenderer>().enabled = false;
        youWin.GetComponent<SpriteRenderer>().enabled = false;

        top = Camera.main.orthographicSize;
        bottom = -top;
        right = top * Camera.main.aspect;
        left = -right;
        for (int i = 0; i < numInvaders; i++)
        {
            Instantiate(spaceInvaderPrefab, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {
        freezeGame = true;
        gameOver.GetComponent<SpriteRenderer>().enabled = true;
    }
    public void YouWin()
    {
        freezeGame = true;
        youWin.GetComponent<SpriteRenderer>().enabled = true;
    }


}