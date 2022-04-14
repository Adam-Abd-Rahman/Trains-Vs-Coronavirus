using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    Distancechecker distancescore; 
    public GameObject TGVtrain;
    public Text ScoreText;
    private float Score;
    //private float pointsDecreasedPerSecond;
    public Text GameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 5f;
        //pointsDecreasedPerSecond = 1.0f;
        distancescore = TGVtrain.GetComponent<Distancechecker>();
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
        ScoreText.text = "Game Score: " + Score;
        //if (Score == 0)
        //{
           //GameOver.text = "Game Over!!";
           //Score = 0;
        //}

        if (distancescore.distance == 1f)
        {
            //Score = Score + 499;
            Debug.Log("Score");
        }
    }
}