using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContents : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private void OnEnable()
    {
        GameManager.scoreEvent += setScore;
    }

    public void setScore(int score)
    {
        scoreText.text = score.ToString();
    }

    private void OnDisable()
    {
        GameManager.scoreEvent -= setScore;
    }
}
