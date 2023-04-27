using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float forca;
    public logicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ) && birdIsAlive) {
            myRigidBody.velocity = Vector2.up * forca;
        }

        if (transform.position.y > 6 || transform.position.y < -6) {
            logic.gameOver();
            birdIsAlive=false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
