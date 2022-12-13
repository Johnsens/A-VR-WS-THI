using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;



public class GameMenuManager : MonoBehaviour
{

    // Different Overlays

    public GameObject gamemenu;
    public GameObject plantPopUp; //Will be deprecated -> See different PlantFoundPopUps
    public GameObject endPopUp;
    public GameObject startMissionOverlay;

    //Button declarations on the Overlays

    public GameObject OverlayToSecondButton;
    public GameObject OverlayToThirdButton;
    public GameObject OverlayToFourthButton;
    public GameObject CloseOverlayButton;

    //Not used right now, would be used to change the content of the Overlays when going through the pages

    public GameObject OverlayPageOne;
    public GameObject OverlayPageTwo;
    public GameObject OverlayPageThree;
    public GameObject OverlayPageFour;
    public GameObject ClosePlantPopup;


    public Transform XRRigPosition;

    private bool onetimeStart = false;
    private bool onetimePlant = false;


    //Values used for counting inventories


    public GameObject FirstPlantFoundPopUp;

    public GameObject SecondPlantFoundPopUp;

    public GameObject ThirdPlantFoundPopUp;

    public int plantCount = 0;


    public InputActionProperty showButton;
    //public Scene multiUserStartScene;

    public Plant plant;

    private NetworkPlayer networkPlayer;

    //variables needed to keep Menu in front of player
    public float spawnDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        showStartMissionOverlay();
        //    showPlantFoundPopUp();
    }

    // Update is called once per frame
    void Update()
    {
        //if (onetimeStart == false) {
        //    updateStartMissionOverlay();
        //    onetimeStart = true;
        //}
        //showMenuSwitch();

        /*if(OverlayToSecondButton.clicked)
         {
             OverlayPageOne.SetActive(false);
             OverlayPageTwo.SetActive(true);

         }

         else if (OverlayToThirdButton.clicked)
         {
             OverlayPageTwo.SetActive(false);
             OverlayPageThree.SetActive(true);
         }
         else if (OverlayToFourthButton.clicked)
         {
             OverlayPageThree.SetActive(false);
             OverlayPageFour.SetActive(true);
         }
         else if (CloseOverlayButton.clicked)
         {
             OverlayPageFour.SetActive(false);
             //start game
         }*/

        //showPlantFoundPopUp();
        //showEndoverlay();
    }


    //Functions to show Overlays
    void showMenuSwitch()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            gamemenu.SetActive(!gamemenu.activeSelf);

            //Defining a Vector to place the menu in front of player by using the normalized vector and manipulating the x and z axis
            gamemenu.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        }

        //Making Sure menu is always facing the player by manipulting the y axis
        gamemenu.transform.LookAt(new Vector3(XRRigPosition.position.x, gamemenu.transform.position.y, XRRigPosition.position.z));
        //flipping the menu around, as it was backwards
        gamemenu.transform.forward *= -1;
    }


    void showPlantFoundPopUp()
    {
        plantPopUp.SetActive(!startMissionOverlay.activeSelf);

        if (plant.isGrabbed == true)
        {
            plantCount += plantCount;
            plantPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
            plantPopUp.transform.LookAt(new Vector3(XRRigPosition.position.x, plantPopUp.transform.position.y, XRRigPosition.position.z));
            XRRigPosition.transform.forward *= -1;
        }

    }
    void updatePlantFoundOverlay()
    {

    }

    /*void showEndPopup() {
        if (ClosePlantPopup.clicked) {
            plantPopup.SetActive(false);
            endPopUp.SetActive(true);
        }
    }*/

    void showStartMissionOverlay()
    {
        //XROrigin rig = FindObjectOfType<XROrigin>();
        //headRig = rig.transform.Find("ViveCameraRig/Camera");
        startMissionOverlay.SetActive(!startMissionOverlay.activeSelf);


    }

    void updateStartMissionOverlay()
    {
        startMissionOverlay.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        startMissionOverlay.transform.LookAt(new Vector3(XRRigPosition.position.x, startMissionOverlay.transform.position.y, XRRigPosition.position.z));
        //flipping the menu around, as it was backwards
        startMissionOverlay.transform.forward *= -1;
    }

    public void showEndoverlay()
    {
        if (endPopUp.activeSelf == true)
        {
            endPopUp.SetActive(!endPopUp.activeSelf);
            endPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        }
    }
}
