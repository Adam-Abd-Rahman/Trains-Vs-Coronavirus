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
        private CinemachineDollyCart PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public Distancechecker distancescore; //Distance checker for Paris.
        public Distancechecker1 distancescore1; //Distance checker for Strasbourg.
        public Distancechecker2 distancescore2; //Distance checker for Bordeaux.
        public Distancechecker3 distancescore3; //Distance checker for Brest.

        public GameObject TGVCarriage1;
        private CinemachineDollyCart PathForCarriage1;
        private CinemachineDollyCart1 Path1ForCarriage1;
        private CinemachineDollyCart2 Path2ForCarriage1;
        private CinemachineDollyCart3 Path3ForCarriage1;
        private CinemachineDollyCart4 Path4ForCarriage1;

        public GameObject TGVMiddleCarriage;
        private CinemachineDollyCart PathForMiddleCarriage;
        private CinemachineDollyCart1 Path1ForMiddleCarriage;
        private CinemachineDollyCart2 Path2ForMiddleCarriage;
        private CinemachineDollyCart3 Path3ForMiddleCarriage;
        private CinemachineDollyCart4 Path4ForMiddleCarriage;

        public GameObject TGVCarriage2;
        private CinemachineDollyCart PathForCarriage2;
        private CinemachineDollyCart1 Path1ForCarriage2;
        private CinemachineDollyCart2 Path2ForCarriage2;
        private CinemachineDollyCart3 Path3ForCarriage2;
        private CinemachineDollyCart4 Path4ForCarriage2;

        public GameObject TGVEngine2;
        private CinemachineDollyCart PathForEngine2;
        private CinemachineDollyCart1 Path1ForEngine2;
        private CinemachineDollyCart2 Path2ForEngine2;
        private CinemachineDollyCart3 Path3ForEngine2;
        private CinemachineDollyCart4 Path4ForEngine2;

        public Slider intersectionslider;
        public Text intersectionslidervalue;

        public GameObject CountdownTimer;
        CountdownTimer timerreset;
        [SerializeField] GameObject timer;

        // Start is called before the first frame update
        void Start()
        {
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            distancescore = TGVEngine1.GetComponent<Distancechecker>(); //Get Distance checker script for Paris from TGV Engine 1 game object.
            distancescore1 = TGVEngine1.GetComponent<Distancechecker1>(); //Get Distance checker script for Strasbourg from TGV Engine 1 game object.
            distancescore2 = TGVEngine1.GetComponent<Distancechecker2>(); //Get Distance checker script for Bordeaux from TGV Engine 1 game object.
            distancescore3 = TGVEngine1.GetComponent<Distancechecker3>(); //Get Distance checker script for Brest from TGV Engine 1 game object.

            PathForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart>();
            Path1ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart1>();
            Path2ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart2>();
            Path3ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart3>();
            Path4ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart4>();

            PathForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart>();
            Path1ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart1>();
            Path2ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart2>();
            Path3ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart3>();
            Path4ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart4>();

            PathForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart>();
            Path1ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart1>();
            Path2ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart2>();
            Path3ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart3>();
            Path4ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart4>();

            PathForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart>();
            Path1ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart4>();

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

                PathForCarriage1.enabled = true;//activate path from Paris to Strasbourg for first car.
                Path1ForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path2ForCarriage1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first car.
                Path3ForCarriage1.enabled = false;//deactivate path from Bordeaux to Paris for first car.
                Path4ForCarriage1.enabled = false;//deactivate path from Paris to Brest for first car.

                PathForMiddleCarriage.enabled = true;//activate path from depot to paris for middle car.
                Path1ForMiddleCarriage.enabled = false;//deactivate path from Paris to Strasbourg for middle car.
                Path2ForMiddleCarriage.enabled = false;//deactivate path from Strasbourg to Bordeaux for middle car.
                Path3ForMiddleCarriage.enabled = false;//deactivate path from Bordeaux to Paris for middle car.
                Path4ForMiddleCarriage.enabled = false;//deactivate path from Paris to Brest for middle car.

                PathForCarriage2.enabled = true;//activate path from depot to paris for second car.
                Path1ForCarriage2.enabled = false;//deactivate path from Paris to Strasbourg for second car.
                Path2ForCarriage2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second car.
                Path3ForCarriage2.enabled = false;//deactivate path from Bordeaux to Paris for second car.
                Path4ForCarriage2.enabled = false;//deactivate path from Paris to Brest for second car.

                PathForEngine2.enabled = true;//activate path from depot to paris for second power car.
                Path1ForEngine2.enabled = false;//deactivate path from Paris to Strasbourg for second power car.
                Path2ForEngine2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second power car.
                Path3ForEngine2.enabled = false;//deactivate path from Bordeaux to Paris for second power car.
                Path4ForEngine2.enabled = false;//deactivate path from Paris to Brest for second power car.

                distancescore.enabled = true; //Activate distance checker script for Paris.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Paris";

            }
            else if (part == 1)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = true;//activate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path1ForCarriage1.enabled = true;//activate path from Paris to Strasbourg for first car.
                Path2ForCarriage1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first car.
                Path3ForCarriage1.enabled = false;//deactivate path from Bordeaux to Paris for first car.
                Path4ForCarriage1.enabled = false;//deactivate path from Paris to Brest for first car.

                PathForMiddleCarriage.enabled = false;//deactivate path from depot to paris for middle car.
                Path1ForMiddleCarriage.enabled = true;//activate path from Paris to Strasbourg for middle car.
                Path2ForMiddleCarriage.enabled = false;//deactivate path from Strasbourg to Bordeaux for middle car.
                Path3ForMiddleCarriage.enabled = false;//deactivate path from Bordeaux to Paris for middle car.
                Path4ForMiddleCarriage.enabled = false;//deactivate path from Paris to Brest for middle car.

                PathForCarriage2.enabled = false;//deactivate path from depot to paris for second car.
                Path1ForCarriage2.enabled = true;//activate path from Paris to Strasbourg for second car.
                Path2ForCarriage2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second car.
                Path3ForCarriage2.enabled = false;//deactivate path from Bordeaux to Paris for second car.
                Path4ForCarriage2.enabled = false;//deactivate path from Paris to Brest for second car.

                PathForEngine2.enabled = false;//deactivate path from depot to paris for second power car.
                Path1ForEngine2.enabled = true;//activate path from Paris to Strasbourg for second power car.
                Path2ForEngine2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second power car.
                Path3ForEngine2.enabled = false;//deactivate path from Bordeaux to Paris for second power car.
                Path4ForEngine2.enabled = false;//deactivate path from Paris to Brest for second power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris.
                distancescore1.enabled = true; //Activate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Strasbourg";

            }
            else if (part == 2)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = true;//activate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path1ForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path2ForCarriage1.enabled = true;//activate path from Strasbourg to Bordeaux for first car.
                Path3ForCarriage1.enabled = false;//deactivate path from Bordeaux to Paris for first car.
                Path4ForCarriage1.enabled = false;//deactivate path from Paris to Brest for first car.

                PathForMiddleCarriage.enabled = false;//deactivate path from depot to paris for middle car.
                Path1ForMiddleCarriage.enabled = false;//deactivate path from Paris to Strasbourg for middle car.
                Path2ForMiddleCarriage.enabled = true;//activate path from Strasbourg to Bordeaux for middle car.
                Path3ForMiddleCarriage.enabled = false;//deactivate path from Bordeaux to Paris for middle car.
                Path4ForMiddleCarriage.enabled = false;//deactivate path from Paris to Brest for middle car.

                PathForCarriage2.enabled = false;//deactivate path from depot to paris for second car.
                Path1ForCarriage2.enabled = false;//deactivate path from Paris to Strasbourg for second car.
                Path2ForCarriage2.enabled = true;//activate path from Strasbourg to Bordeaux for second car.
                Path3ForCarriage2.enabled = false;//deactivate path from Bordeaux to Paris for second car.
                Path4ForCarriage2.enabled = false;//deactivate path from Paris to Brest for second car.

                PathForEngine2.enabled = false;//deactivate path from depot to paris for second power car.
                Path1ForEngine2.enabled = false;//deactivate path from Paris to Strasbourg for second power car.
                Path2ForEngine2.enabled = true;//activate path from Strasbourg to Bordeaux for second power car.
                Path3ForEngine2.enabled = false;//deactivate path from Bordeaux to Paris for second power car.
                Path4ForEngine2.enabled = false;//deactivate path from Paris to Brest for second power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = true;  //Activate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Bordeaux";

            }
            else if (part == 3)
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = true;//activate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = false;//deactivate path from Paris to Brest for first power car.

                PathForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path1ForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path2ForCarriage1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first car.
                Path3ForCarriage1.enabled = true;//activate path from Bordeaux to Paris for first car.
                Path4ForCarriage1.enabled = false;//deactivate path from Paris to Brest for first car.

                PathForMiddleCarriage.enabled = false;//deactivate path from depot to paris for middle car.
                Path1ForMiddleCarriage.enabled = false;//deactivate path from Paris to Strasbourg for middle car.
                Path2ForMiddleCarriage.enabled = false;//deactivate path from Strasbourg to Bordeaux for middle car.
                Path3ForMiddleCarriage.enabled = true;//activate path from Bordeaux to Paris for middle car.
                Path4ForMiddleCarriage.enabled = false;//deactivate path from Paris to Brest for middle car.

                PathForCarriage2.enabled = false;//deactivate path from depot to paris for second car.
                Path1ForCarriage2.enabled = false;//deactivate path from Paris to Strasbourg for second car.
                Path2ForCarriage2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second car.
                Path3ForCarriage2.enabled = true;//activate path from Bordeaux to Paris for second car.
                Path4ForCarriage2.enabled = false;//deactivate path from Paris to Brest for second car.

                PathForEngine2.enabled = false;//deactivate path from depot to paris for second power car.
                Path1ForEngine2.enabled = false;//deactivate path from Paris to Strasbourg for second power car.
                Path2ForEngine2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second power car.
                Path3ForEngine2.enabled = true;//activate path from Bordeaux to Paris for second power car.
                Path4ForEngine2.enabled = false;//deactivate path from Paris to Brest for second power car.

                distancescore.enabled = true; //Activate distance checker script for Paris.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = false; //Deactivate distance checker script for Brest.

                intersectionslidervalue.text = "To Paris from Bordeaux";

            }
            else
            {
                PathForEngine1.enabled = false;//deactivate path from depot to Paris for first power car.
                Path1ForEngine1.enabled = false;//deactivate path from Paris to Strasbourg for first power car.
                Path2ForEngine1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first power car.
                Path3ForEngine1.enabled = false;//deactivate path from Bordeaux to Paris for first power car.
                Path4ForEngine1.enabled = true;//activate path from Paris to Brest for first power car.

                PathForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path1ForCarriage1.enabled = false;//deactivate path from Paris to Strasbourg for first car.
                Path2ForCarriage1.enabled = false;//deactivate path from Strasbourg to Bordeaux for first car.
                Path3ForCarriage1.enabled = false;//deactivate path from Bordeaux to Paris for first car.
                Path4ForCarriage1.enabled = true;//activate path from Paris to Brest for first car.

                PathForMiddleCarriage.enabled = false;//deactivate path from depot to paris for middle car.
                Path1ForMiddleCarriage.enabled = false;//deactivate path from Paris to Strasbourg for middle car.
                Path2ForMiddleCarriage.enabled = false;//deactivate path from Strasbourg to Bordeaux for middle car.
                Path3ForMiddleCarriage.enabled = false;//deactivate path from Bordeaux to Paris for middle car.
                Path4ForMiddleCarriage.enabled = true;//activate path from Paris to Brest for middle car.

                PathForCarriage2.enabled = false;//deactivate path from depot to paris for second car.
                Path1ForCarriage2.enabled = false;//deactivate path from Paris to Strasbourg for second car.
                Path2ForCarriage2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second car.
                Path3ForCarriage2.enabled = false;//deactivate path from Bordeaux to Paris for second car.
                Path4ForCarriage2.enabled = true;//activate path from Paris to Brest for second car.

                PathForEngine2.enabled = false;//deactivate path from depot to paris for second power car.
                Path1ForEngine2.enabled = false;//deactivate path from Paris to Strasbourg for second power car.
                Path2ForEngine2.enabled = false;//deactivate path from Strasbourg to Bordeaux for second power car.
                Path3ForEngine2.enabled = false;//deactivate path from Bordeaux to Paris for second power car.
                Path4ForEngine2.enabled = true;//activate path from Paris to Brest for second power car.

                distancescore.enabled = false; //Deactivate distance checker script for Paris.
                distancescore1.enabled = false; //Deactivate distance checker script for Strasbourg.
                distancescore2.enabled = false; //Deactivate distance checker script for Bordeaux.
                distancescore3.enabled = true; //Activate distance checker script for Brest.

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
