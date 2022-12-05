using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GrabberPool = HTC.UnityPlugin.Utility.ObjectPool<Draggable.Grabber>;

public class Plant : MonoBehaviour
{

    public class plant{

        public string name;
        public string scientificname;
        public string description;
        public bool discovered;
        public bool poisonous;
        public GameObject plantModel;

        //public image image;

        public plant(string name, string science, string desc, bool disco, bool poison, GameObject model){
            name = name;
            scientificname = science;
            desc = description;
            discovered = disco;
            poisonous = poison;
            plantModel = model;
        }
    }

            public plant Alpenveilchen = new plant("Alpenveilchen", "XY", "Eine sehr schöne Pflanze", false, true, );
            //public plant Brennessel = new plant("Brennessel", "XY", "Eine sehr gesunde Pflanze", false, false);


    

    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (plant.model.isGrabbed == true) {
            plant.model.SetActive(false);
        }
    }
}
