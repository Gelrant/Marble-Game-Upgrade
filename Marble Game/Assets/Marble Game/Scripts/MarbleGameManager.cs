using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Diagnostics;

public enum MarbleGameState {playing, won,lost };

public class MarbleGameManager : MonoBehaviour
{
    public static MarbleGameManager SP;
    public static bool canPause = true;
    private int totalGems;
    private int foundGems;
    private MarbleGameState gameState;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    public GameObject interfaceCanvas;
    public Text scoreText;
    public Text loseTimeText;
    public Text winTimeText;
    public Text interfaceScoreText;
    public Text interfaceTimeText;
    private string passedTime;
    

    
    
    Stopwatch timer = new Stopwatch();


    void Awake()
    {
        SP = this; 
        foundGems = 0;
        timer.Start();
        gameState = MarbleGameState.playing;
        totalGems = GameObject.FindGameObjectsWithTag("Pickup").Length;
        Time.timeScale = 1.0f;
    }



	void Update () {


        if (gameState == MarbleGameState.lost)
        {
            canPause = false;
            interfaceCanvas.SetActive(false);
            timer.Stop();
            int elapsedSeconds = (int)timer.Elapsed.TotalSeconds;
            passedTime = elapsedSeconds.ToString();
           
            loseTimeText.text = "Time " + passedTime;
            scoreText.text = "Score " + foundGems.ToString() + "/" + "18";
            loseCanvas.SetActive(true);

        }
        else if (gameState == MarbleGameState.won)
        {
            canPause = false;
            interfaceCanvas.SetActive(false);
            timer.Stop();
            int elapsedSeconds = (int)timer.Elapsed.TotalSeconds;
            passedTime = elapsedSeconds.ToString();
            winTimeText.text = "Time " + passedTime;
            winCanvas.SetActive(true);

        }
        else
        {
            canPause = true;
            if (PauseMenu.isPaused == true)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
            int elapsedSeconds = (int)timer.Elapsed.TotalSeconds;
            passedTime = elapsedSeconds.ToString();
            interfaceScoreText.text = "SCORE " + foundGems.ToString() + "/" + "18";
            interfaceTimeText.text = "Time " + passedTime;
            interfaceCanvas.SetActive(true);
        }
	}

    public void FoundGem()
    {
        foundGems++;
        if (foundGems >= totalGems)
        {
            WonGame();
        }
    }

    public void PlayAgain()
    {
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
        canPause = true;
        Application.LoadLevel(Application.loadedLevel);
    }

    public void MainMenu()
    {
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
        canPause = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void WonGame()
    {
        Time.timeScale = 0.0f; //Pause game
        gameState = MarbleGameState.won;
    }

    public void SetGameOver()
    {
        Time.timeScale = 0.0f; //Pause game
        gameState = MarbleGameState.lost;
    }
}
