using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Distancechecker0 : MonoBehaviour
    {

        // Reference to checkpoint position
        [SerializeField]
        private Transform checkpoint;

        // Reference to UI text that shows the distance value
        [SerializeField]
        private Text distanceText;

        // Calculated distance value
        private float distance;

        private float plusscore = 529f;
        private float pluscorefor0meters = 729f;

        CinemachineDollyCart0 cinemachinedollycart;

        public GameObject drivingpanel;
        private GameScore ScoreByDistance;

        // Start is called before the first frame update
        void Start()
        {
            cinemachinedollycart = GetComponent<CinemachineDollyCart0>();
        
            ScoreByDistance = drivingpanel.GetComponent<GameScore>();
        }

        // Update is called once per frame
        private void Update()
        {

            // Calculate distance value between character and checkpoint
            distance = (checkpoint.transform.position - transform.position).magnitude;

            // Display distance value via UI text
            // distance.ToString("F1") shows value with 1 digit after period
            // so 12.234 will be shown as 12.2 for example
            // distance.ToString("F2") will show 12.23 in this case
            distanceText.text = "Distance: " + distance.ToString("F1") + " meters";

            if (cinemachinedollycart.m_Position > 70.9f && cinemachinedollycart.m_Position < 71.3f)
            {
                ScoreByDistance.SetScoreText(plusscore);
                Debug.Log("529 (at Paris)");
            }

            if (cinemachinedollycart.m_Position == 71.3f)
            {
                ScoreByDistance.SetScoreText(pluscorefor0meters);
                Debug.Log("729 (at Paris)");
            }
        }

    }
}