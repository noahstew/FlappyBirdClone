using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2d;
    private float jumpSpeed = 20;
    public LogicScript logic;
    public static bool birdIsAlive;

    // Start is called before the first frame update
    void Start() {
        // if this is the first time, startScreen.setActive(true) else, run the code below
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        if(LogicScript.onStart)
        {
            logic.gameStartUI();
            LogicScript.onStart = false;
            Destroy(gameObject);
        }
        else
        {
            birdIsAlive = true;
            logic.score.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
            {
                myRigidbody2d.velocity = Vector2.up * jumpSpeed;
            }
            if ((transform.position.y < -15 || transform.position.y > 17) && birdIsAlive) // If goes off screen on bottom
            {
                endGame();
            }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            endGame();
        }
    }

    private void endGame() 
    {   
        Destroy(gameObject);
        logic.score.SetActive(false);
        logic.gameOverUI();
        birdIsAlive = false;
    }
}
