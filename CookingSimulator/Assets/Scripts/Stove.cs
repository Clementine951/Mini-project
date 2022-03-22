using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    // End of the animation where the caractere hold a steak
    public Animator GrabSteak;
    private bool test = false;

    public void OnTriggerEnter(Collider other)
    {
        print("Press S to put your uncooked steak on the pan");

        test = true;
    }

    public void OnTriggerExit(Collider other)
    {
        test = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (test)
        {
            if (Input.GetKey(KeyCode.S))
            {
                GrabSteak.SetBool("Steak", false);
            }
        }
    }

} // Works



