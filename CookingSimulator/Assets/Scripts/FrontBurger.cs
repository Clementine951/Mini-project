using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBurger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        print("You're in front of the burger! Press B and come closer to grab it.");
    }

    public void OnTriggerExit(Collider other)
    {
        print("Pres C to realese it");
    }
}
