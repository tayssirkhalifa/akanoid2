using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameSession : MonoBehaviour
{



    public Text LivesText;
    public Text ScoreText;
    public Text HiScoreText;
    public int startLives;
    public int currentLives = 5;
    private int currentScore;
    private int currentHiScore;
    private void Awake()
    {
        int instanceCount = FindObjectsOfType<GameSession>().Length;
        if (instanceCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

	// Use this for initialization
	void Start () {

        startLives=currentLives;
	}
    
	// Update is called once per frame
	void Update () {
        var balls = GameObject.FindGameObjectsWithTag("Ball");
        if (balls.Length <= 0)
        {
            DecreaseLives();
            GameObject.FindWithTag("Player").GetComponent<playerController>().ResetBall();
        }
        LivesText.text = currentLives.ToString();
        ScoreText.text = currentScore.ToString();
	}


    public void IncreaseScore(int Value)
    {
        currentScore += Value;
    }



    public void DecreaseLives()
    {
        if (currentLives == 5)
        {
           currentLives = 4;
        }

        currentLives = currentLives-1;
        if (currentLives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        print("game over");
    }
}
