using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public GameObject points;

    [SerializeField] Text countdownText;

    private float Timerstarts;
    private float Second;

    // Start is called before the first frame update
    void Start()
    {
        Timerstarts = 5f;
        Second = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timerstarts -= Second * Time.deltaTime;
        countdownText.text = Timerstarts.ToString ("0");

        if (Timerstarts <= 0) {
            Timerstarts = 0;
            //points.SetActive(true);
        }
    }
}