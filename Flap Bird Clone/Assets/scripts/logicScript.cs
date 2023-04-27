using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//me permite trabalhar com textos do canvas
using UnityEngine.UI;

//trabalhar com cenas
using UnityEngine.SceneManagement;


public class logicScript : MonoBehaviour
{

    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;

    
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        score.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
