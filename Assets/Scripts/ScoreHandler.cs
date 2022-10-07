using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreHandler : MonoBehaviour
{

    [SerializeField] TMP_Text highScoreText;
    [SerializeField] TMP_Text currentScoreText;

    
    [SerializeField] int setScore;
    [SerializeField] int scoreDecreaseByBump;


    private string highScoreKey = "HighScoreKey";
    private int highScore;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = PlayerPrefs.GetInt(highScoreKey, 0).ToString();
        currentScoreText.text = setScore.ToString();
        currentScore = setScore;
    }

    // Update is called once per frame
    void Update()
    {
        currentScoreText.text = currentScore.ToString();
        RestartLevel();
    }

    public void ScoreDecreesing()
    {
        currentScore -= scoreDecreaseByBump;
    }

    private void RestartLevel()
    {
        if (currentScore <= 0)
        {
            currentScore = 0;
            SceneManager.LoadScene(0);
        }
    }

    public void SetHighScore()
    {
        if (highScore < currentScore)
        {
            PlayerPrefs.SetInt(highScoreKey, currentScore);
        }
    }
}
