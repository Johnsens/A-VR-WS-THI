using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    public class PlantClass {
        public string name;
        public string description;
        public bool discovered;
        //public image image;

        public PlantClass(string name, string desc, bool disco){
            name = name;
            desc = description;
            discovered = disco;
        }
    }

    public PlantClass Alpenveilchen = new PlantClass("Alpenveilchen", "Eine sehr schöne Pflanze", false);




    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Alpenveilchen.discovered == true) {
        //    show PlantFoundPopUp
        //}
    }
}
