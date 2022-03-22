using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    public Animator doorOpening;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        doorOpening.SetBool("DoorsOpen", true);
    }
    

    private void OnTriggerExit(Collider other)
    {
        doorOpening.SetBool("DoorsOpen", false);
    }

}
