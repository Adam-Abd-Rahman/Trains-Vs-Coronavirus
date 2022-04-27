using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class intersectioncontroller : MonoBehaviour
    {
        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart0 PathForEnginefrontbogie1;
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1;
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1;
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1;
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1;

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart0 PathForEnginerearbogie1;
        private CinemachineDollyCart1 Path1ForEnginerearbogie1;
        private CinemachineDollyCart2 Path2ForEnginerearbogie1;
        private CinemachineDollyCart3 Path3ForEnginerearbogie1;
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;

        public Distancechecker0 distancescore; //Distance checker for Paris from Depot.
        public Distancechecker1 distancescore1; //Distance checker for Strasbourg.
        public Distancechecker2 distancescore2; //Distance checker for Bordeaux.
        public Distancechecker3 distancescore3; //Distance checker for Paris.
        public Distancechecker4 distancescore4; //Distance checker for Brest.

        public Slider intersectionslider;
        public Text intersectionslidervalue;

        public GameObject CountdownTimer;
        CountdownTimer timerreset;
        [SerializeField] GameObject timer;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1_1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            TGVEngine1 = GameObject.Find("Engine_1_front_bogie_and_wheel");
            PathForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart4>();

            TGVEngine1 = GameObject.Find("Engine_1_rear_bogie_and_wheel");
            PathForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart4>();

            distancescore = TGVEngine1.GetComponent<Distancechecker0>(); //Get Distance checker script for depot to Paris from TGV Engine 1 game object.
            distancescore1 = TGVEngine1.GetComponent<Distancechecker1>(); //Get Distance checker script for Strasbourg from TGV Engine 1 game object.
            distancescore2 = TGVEngine1.GetComponent<Distancechecker2>(); //Get Distance checker script for Bordeaux from TGV Engine 1 game object.
            distancescore3 = TGVEngine1.GetComponent<Distancechecker3>(); //Get Distance checker script for Paris from TGV Engine 1 game object.
            distancescore4 = TGVEngine1.GetComponent<Distancechecker4>(); //Get Distance checker script for Brest from TGV Engine 1 game object.

            ChangeDestination(0);
            intersectionslider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
            
            timerreset = timer.GetComponent<CountdownTimer>();
        }

        public void ChangeDestination(int part)
        {
            if (part == 0)
            {
                PathForEngine1.enabled = true;//activate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForEnginefrontbogie1.enabled = true;//activate path from depot to Paris for front bogie of the first power car.
                Path1ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Strasbourg for front bogie of the first power car.
                Path2ForEnginefrontbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for front bogie of the first power car.
                Path3ForEnginefrontbogie1.enabled = false;//deactivate path from Bordeaux to Paris for front bogie of the first power car.
                Path4ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Brest for front bogie of the first power car.

                PathForEnginerearbogie1.enabled = true;//activate path from depot to Paris for rear bogie of the first power car.
                Path1ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Strasbourg for rear bogie of the first power car.
                Path2ForEnginerearbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for rear bogie of the first power car.
                Path3ForEnginerearbogie1.enabled = false;//deactivate path from Bordeaux to Paris for rear bogie of the first power car.
                Path4ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Brest for rear bogie of the first power car.

                distancescore.enabled = true; //Activate distance checker script for Paris from depot.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Paris.
                distancescore4.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Paris";

            }
            else if (part == 1)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = true;//activate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForEnginefrontbogie1.enabled = false;//deactivate path from depot to Paris for front bogie of the first power car.
                Path1ForEnginefrontbogie1.enabled = true;//activate path from Paris to Strasbourg for front bogie of the first power car.
                Path2ForEnginefrontbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for front bogie of the first power car.
                Path3ForEnginefrontbogie1.enabled = false;//deactivate path from Bordeaux to Paris for front bogie of the first power car.
                Path4ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Brest for front bogie of the first power car.

                PathForEnginerearbogie1.enabled = false;//deactivate path from depot to Paris for rear bogie of the first power car.
                Path1ForEnginerearbogie1.enabled = true;//activate path from Paris to Strasbourg for rear bogie of the first power car.
                Path2ForEnginerearbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for rear bogie of the first power car.
                Path3ForEnginerearbogie1.enabled = false;//deactivate path from Bordeaux to Paris for rear bogie of the first power car.
                Path4ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Brest for rear bogie of the first power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris from depot.
                distancescore1.enabled = true; //Activate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Paris.
                distancescore4.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Strasbourg";

                CountdownTimer.SetActive(true);
                timerreset.Timerstarts = 50f;

            }
            else if (part == 2)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = true;//activate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForEnginefrontbogie1.enabled = false;//deactivate path from depot to Paris for front bogie of the first power car.
                Path1ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Strasbourg for front bogie of the first power car.
                Path2ForEnginefrontbogie1.enabled = true;//activate path from Strasbourg to Bordeaux for front bogie of the first power car.
                Path3ForEnginefrontbogie1.enabled = false;//deactivate path from Bordeaux to Paris for front bogie of the first power car.
                Path4ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Brest for front bogie of the first power car.

                PathForEnginerearbogie1.enabled = false;//deactivate path from depot to Paris for rear bogie of the first power car.
                Path1ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Strasbourg for rear bogie of the first power car.
                Path2ForEnginerearbogie1.enabled = true;//activate path from Strasbourg to Bordeaux for rear bogie of the first power car.
                Path3ForEnginerearbogie1.enabled = false;//deactivate path from Bordeaux to Paris for rear bogie of the first power car.
                Path4ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Brest for rear bogie of the first power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris from depot.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = true; //Activate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Paris.
                distancescore4.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Bordeaux";

                CountdownTimer.SetActive(true);
                timerreset.Timerstarts = 50f;

            }
            else if (part == 3)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = true;//activate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForEnginefrontbogie1.enabled = false;//deactivate path from depot to Paris for front bogie of the first power car.
                Path1ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Strasbourg for front bogie of the first power car.
                Path2ForEnginefrontbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for front bogie of the first power car.
                Path3ForEnginefrontbogie1.enabled = true;//activate path from Bordeaux to Paris for front bogie of the first power car.
                Path4ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Brest for front bogie of the first power car.

                PathForEnginerearbogie1.enabled = false;//deactivate path from depot to Paris for rear bogie of the first power car.
                Path1ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Strasbourg for rear bogie of the first power car.
                Path2ForEnginerearbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for rear bogie of the first power car.
                Path3ForEnginerearbogie1.enabled = true;//activate path from Bordeaux to Paris for rear bogie of the first power car.
                Path4ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Brest for rear bogie of the first power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris from depot.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Dectivate distance checker script for Bordeaux.
                distancescore3.enabled = true; //Activate distance checker script for Paris.
                distancescore4.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Paris from Bordeaux";

                CountdownTimer.SetActive(true);
                timerreset.Timerstarts = 50f;

            }
            else
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = true;//activate path from Paris to Brest for first power car.

                PathForEnginefrontbogie1.enabled = false;//deactivate path from depot to Paris for front bogie of the first power car.
                Path1ForEnginefrontbogie1.enabled = false;//deactivate path from Paris to Strasbourg for front bogie of the first power car.
                Path2ForEnginefrontbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for front bogie of the first power car.
                Path3ForEnginefrontbogie1.enabled = false;//deactivate path from Bordeaux to Paris for front bogie of the first power car.
                Path4ForEnginefrontbogie1.enabled = true;//activate path from Paris to Brest for front bogie of the first power car.

                PathForEnginerearbogie1.enabled = false;//deactivate path from depot to Paris for rear bogie of the first power car.
                Path1ForEnginerearbogie1.enabled = false;//deactivate path from Paris to Strasbourg for rear bogie of the first power car.
                Path2ForEnginerearbogie1.enabled = false;//deactivate path from Strasbourg to Bordeaux for rear bogie of the first power car.
                Path3ForEnginerearbogie1.enabled = false;//deactivate path from Bordeaux to Paris for rear bogie of the first power car.
                Path4ForEnginerearbogie1.enabled = true;//activate path from Paris to Brest for rear bogie of the first power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris from depot.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Dectivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Activate distance checker script for Paris.
                distancescore4.enabled = true; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Brest";

                CountdownTimer.SetActive(true);
                timerreset.Timerstarts = 50f;
            }
        }

        public void ValueChangeCheck()
        {
            if (intersectionslider.value == 0f)
            {
                ChangeDestination(0);
            }
            else if (intersectionslider.value == 1f)
            {
                ChangeDestination(1);
            }
            else if (intersectionslider.value == 2f)
            {
                ChangeDestination(2);
            }
            else if (intersectionslider.value == 3f)
            {
                ChangeDestination(3);
            }
            else
            {
                ChangeDestination(4);
            }
        }
    }
}
