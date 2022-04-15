using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public Distancechecker distancescore;
    public Distancechecker1 distancescore1;
    public GameObject TGVtrain;
    public Text ScoreText;
    public float Score;
    //private float pointsDecreasedPerSecond;
    public Text GameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 5f;
        //pointsDecreasedPerSecond = 1.0f;
        distancescore = TGVtrain.GetComponent<Distancechecker>();
        distancescore1 = TGVtrain.GetComponent<Distancechecker1>();
        GameOver.text = "";
        Score = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Score -= pointsDecreasedPerSecond * Time.deltaTime;
        //ScoreText.text = Score.ToString("0");
        Debug.Log(distancescore.distance);
        Debug.Log(distancescore1.distance);
        SetScoreText();
    }

    void SetScoreText()
    {
        ScoreText.text = "Game Score: " + Score;
        //if (Score == 0)
        //{
           //GameOver.text = "Game Over!!";
           //Score = 0;
        //}

        if (distancescore.distance < 1f)
        {
            Score = Score + 499;
            //Debug.Log("Add score");
        }

        if (distancescore.distance == 0f)
        {
            Score = Score + 499 * 50;
            //Debug.Log("Add score");
        }
    }

    //void setscore1()
    //{
        //if (distancescore1.distance < 1f)
        //{
            //Score = Score + 499;
            //Debug.Log("Add score");
        //}

        //if (distancescore1.distance == 0f)
        //{
            //Score = Score + 499 * 50;
            //Debug.Log("Add score");
        //}
    //}
}