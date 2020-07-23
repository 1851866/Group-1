using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HighScore : MonoBehaviour
{
   
    public int CurrentScore_;
    public int HighScore_;


    private bool IsCounting = false;
    private float CurrentScoreF;

    [SerializeField]
    TextMeshProUGUI currScore;

    [SerializeField]
    TextMeshProUGUI highScore;


    public void Start_S()
    {   
        
        IsCounting = true;
    }

    public void Stop_S()
    {
        IsCounting = false;
        CurrentScoreF = 0;
    }

    public void Pause_S()
    {
        IsCounting = false;
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }

    void Start()
    {
        CurrentScoreF = 0;
        PlayerPrefs.SetInt("LastScore", 0);
    }

    void Update()
    {

        if (IsCounting== true)
        {
            CountScore();
        }

        currScore.text = "Score - " + CurrentScore_.ToString();
        highScore.text = "High - " + HighScore_.ToString();
    }
    void CountScore()
    {
        CurrentScoreF += Time.deltaTime;
        CurrentScore_ = Mathf.FloorToInt(CurrentScoreF);

        HighScore_ = PlayerPrefs.GetInt("HighScore", 0);
        PlayerPrefs.SetInt("LastScore", CurrentScore_);
        if (CurrentScore_ > HighScore_)
        {
            PlayerPrefs.SetInt("HighScore", CurrentScore_);
        }
    }
}
