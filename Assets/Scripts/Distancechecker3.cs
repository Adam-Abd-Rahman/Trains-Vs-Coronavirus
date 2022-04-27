using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Distancechecker3 : MonoBehaviour
    {

        // Reference to checkpoint position
        [SerializeField]
        private Transform checkpoint;

        // Reference to UI text that shows the distance value
        [SerializeField]
        private Text distanceText;

        // Calculated distance value
        private float distance;

        private float plusscore = 4715f;
        private float pluscorefor0meters = 5214f;

        CinemachineDollyCart3 cinemachinedollycart3;

        public GameObject drivingpanel;
        private GameScore ScoreByDistance;

        // Start is called before the first frame update
        void Start()
        {
            cinemachinedollycart3 = GetComponent<CinemachineDollyCart3>();

            ScoreByDistance = drivingpanel.GetComponent<GameScore>();
        }

        // Update is called once per frame
        private void Update()
        {

            // Calculate distance value between character and checkpoint
            distance = (checkpoint.position - transform.position).magnitude;

            // Display distance value via UI text
            // distance.ToString("F1") shows value with 1 digit after period
            // so 12.234 will be shown as 12.2 for example
            // distance.ToString("F2") will show 12.23 in this case
            distanceText.text = "Distance: " + distance.ToString("F1") + " meters";

            if (cinemachinedollycart3.m_Position > 74.3f && cinemachinedollycart3.m_Position < 75.1f)
            {
                ScoreByDistance.SetScoreText(plusscore);
            }

            if (cinemachinedollycart3.m_Position == 75.2f)
            {
                ScoreByDistance.SetScoreText(pluscorefor0meters);
            }
        }

    }
}
