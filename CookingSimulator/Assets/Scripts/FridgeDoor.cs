using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    // the player need a plate to take ingredients
    // grab a steak with S
    // grab a tomato with T
    // grab a cheese with C
    // grab a salad with S
    // press x  to realese 
    public Animator doorOpening;
    public Animator GrabSteak;
    public Animator GrabTomato;
    public Animator grabSalad;
    public Animator grabCheese;
    public PantryDoors paD;
    private bool test = false;

    public bool steak = false;
    public bool tomato = false;
    public bool cheese = false;
    public bool salad = false;


    public void OnTriggerEnter(Collider other)
    {
        //Opening of fridge doors

        test = true;
        doorOpening.SetBool("DoorsOpen", true);

        if (paD.havePlate)
        {
            print("Press S to grab a steak");
            print("Press T to grab a tomato");
            print("Press L to grab salad");
            print("Press F to grab cheese");
        }else
        {
            print("You need a plate to take ingredients.");
        }
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
            if (paD.havePlate)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    paD.grabPlate.SetBool("grabPlate", false);
                    GrabSteak.SetBool("Steak", true);
                    steak = true;
                }
                if (Input.GetKey(KeyCode.T))
                {
                    paD.grabPlate.SetBool("grabPlate", false);
                    GrabTomato.SetBool("Tomato", true);
                    tomato = true;
                }
                if (Input.GetKey(KeyCode.L))
                {
                    paD.grabPlate.SetBool("grabPlate", false);
                    grabSalad.SetBool("Salad", true);
                    salad = true;
                }
                if (Input.GetKey(KeyCode.F))
                {
                    paD.grabPlate.SetBool("grabPlate", false);
                    grabCheese.SetBool("Cheese", true);
                    cheese = true;
                }
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            GrabSteak.SetBool("Steak", false);
            steak = false;
            GrabTomato.SetBool("Tomato", false);
            tomato = false;
            grabSalad.SetBool("Salad", false);
            salad = false;
            grabCheese.SetBool("Cheese", false);
            cheese = false;
        }
    }
}    
