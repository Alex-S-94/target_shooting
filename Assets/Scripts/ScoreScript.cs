using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text ShowScore;

    [SerializeField]
    private int score;  //serialized for testing purpose
 
    public int Score { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        //ShowScore.SetText(score.ToString());
        ShowScore.text = score.ToString();
    }
}
