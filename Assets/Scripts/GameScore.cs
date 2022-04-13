using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public GameObject TGV;
    public Text ScoreText;
    private int Score;
    //private float pointsDecreasedPerSecond;
    public Text GameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 5f;
        //pointsDecreasedPerSecond = 1.0f;
        //Distancechecker distancescore = TGV.GetComponent<Distancechecker>();
        GameOver.text = "";
        Score = 5;
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        //Score -= pointsDecreasedPerSecond * Time.deltaTime;
        //ScoreText.text = Score.ToString("0");
    }

    void SetScoreText()
    {
        ScoreText.text = "Game Score: " + Score.ToString();
        if (Score == 0)
        {
           GameOver.text = "Game Over!!";
           Score = 0;
        }

        //Debug.Log(distancescore.distance);
        //if (distance == 0)
        //{
        //Score = Score + 499;
        //}

    }

}