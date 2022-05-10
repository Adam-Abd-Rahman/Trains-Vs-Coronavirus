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
        private CinemachineDollyCart0 PathForEngine1; //Get script named CinemachineDollyCart0 from Engine_1_1 for Paris from Depot.
        private CinemachineDollyCart1 Path1ForEngine1; //Get script named CinemachineDollyCart1 from Engine_1_1 for Strasbourg.
        private CinemachineDollyCart2 Path2ForEngine1; //Get script named CinemachineDollyCart2 from Engine_1_1 for Bordeaux.
        private CinemachineDollyCart3 Path3ForEngine1; //Get script named CinemachineDollyCart3 from Engine_1_1 for Paris.
        private CinemachineDollyCart4 Path4ForEngine1; //Get script named CinemachineDollyCart4 from Engine_1_1 for Brest.
        private Distancechecker0 distancescore; //Distance checker for Paris from Depot.
        private Distancechecker1 distancescore1; //Distance checker for Strasbourg.
        private Distancechecker2 distancescore2; //Distance checker for Bordeaux.
        private Distancechecker3 distancescore3; //Distance checker for Paris.
        private Distancechecker4 distancescore4; //Distance checker for Brest.

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart0 PathForEnginefrontbogie1; //Get script named CinemachineDollyCart0 from TGVEnginefrontbogie1 for Paris from Depot.
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1; //Get script named CinemachineDollyCart1 from TGVEnginefrontbogie1 for Strasbourg.
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1; //Get script named CinemachineDollyCart2 from TGVEnginefrontbogie1 for Bordeaux.
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1; //Get script named CinemachineDollyCart3 from TGVEnginefrontbogie1 for Paris.
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1; //Get script named CinemachineDollyCart4 from TGVEnginefrontbogie1 for Brest.

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart0 PathForEnginerearbogie1; //Get script named CinemachineDollyCart0 from TGVEnginerearbogie1 for Paris from Depot.
        private CinemachineDollyCart1 Path1ForEnginerearbogie1; //Get script named CinemachineDollyCart1 from TGVEnginerearbogie1 for Strasbourg.
        private CinemachineDollyCart2 Path2ForEnginerearbogie1; //Get script named CinemachineDollyCart2 from TGVEnginerearbogie1 for Bordeaux.
        private CinemachineDollyCart3 Path3ForEnginerearbogie1; //Get script named CinemachineDollyCart3 from TGVEnginerearbogie1 for Paris.
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;//Get script named CinemachineDollyCart4 from TGVEnginerearbogie1 for Brest.

        public Slider intersectionslider;
        public Text intersectionslidervalue;

        public GameObject Canvastobrest;
        public GameObject CanvastoParis;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("TGV");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();
            distancescore = TGVEngine1.GetComponent<Distancechecker0>(); //Get Distance checker script for depot to Paris from TGV Engine 1 game object.
            distancescore1 = TGVEngine1.GetComponent<Distancechecker1>(); //Get Distance checker script for Strasbourg from TGV Engine 1 game object.
            distancescore2 = TGVEngine1.GetComponent<Distancechecker2>(); //Get Distance checker script for Bordeaux from TGV Engine 1 game object.
            distancescore3 = TGVEngine1.GetComponent<Distancechecker3>(); //Get Distance checker script for Paris from TGV Engine 1 game object.
            distancescore4 = TGVEngine1.GetComponent<Distancechecker4>(); //Get Distance checker script for Brest from TGV Engine 1 game object.

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
        }

        public void ChangeDestination()
        {
            if (intersectionslider.value == 0f)
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

                Canvastobrest.SetActive(false);
                CanvastoParis.SetActive(true);

            }
            else if (intersectionslider.value == 1f)
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

                Canvastobrest.SetActive(false);
                CanvastoParis.SetActive(true);
            }
            else if (intersectionslider.value == 2f)
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

                Canvastobrest.SetActive(false);
                CanvastoParis.SetActive(true);
            }
            else if (intersectionslider.value == 3f)
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

                Canvastobrest.SetActive(true);
                CanvastoParis.SetActive(false);                
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

                Canvastobrest.SetActive(false);
                CanvastoParis.SetActive(true);
            }
        }
    }
}