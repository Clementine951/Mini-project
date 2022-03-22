using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    public Animator doorOpening;
    public Animator GrabSteak;
    public Animator GrabTomato;
    public Animator grabSalad;
    public Animator grabCheese;

    private bool test = false;

    public void OnTriggerEnter(Collider other)
    {
        //Opening of fridge doors
        // grab a steak with S
        // grab a tomato with T

        test = true;
        doorOpening.SetBool("DoorsOpen", true);

        print("Press S to grab a steak");
        print("Press T to grab a tomato");
        print("Press L to grab salad");

    }


    public void OnTriggerExit(Collider other)
    {
        doorOpening.SetBool("DoorsOpen", false);
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
                GrabSteak.SetBool("Steak", true);
            }
            if (Input.GetKey(KeyCode.T))
            {
                GrabTomato.SetBool("Tomato", true);
            }
            if (Input.GetKey(KeyCode.L))
            {
                grabSalad.SetBool("Salad", true);
            }
            if (Input.GetKey(KeyCode.F))
            {
                grabCheese.SetBool("Cheese", true);
            }


        }
        if (Input.GetKey(KeyCode.X))
        {
            GrabSteak.SetBool("Steak", false);
            GrabTomato.SetBool("Tomato", false);
            grabSalad.SetBool("Salad", false);
            grabCheese.SetBool("Cheese", false);
        }
    }

    
}