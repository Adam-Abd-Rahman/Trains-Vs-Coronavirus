using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class ManualControl : MonoBehaviour
{
    public Slider Power;

    // Start is called before the first frame update
    void Start()
    {
        // Changes the max value of the slider to 160;
        Power.maxValue = 160;
    }
}
