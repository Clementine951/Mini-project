using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantryDoors : MonoBehaviour
{
    // The caracter open the pantry when press N
    // Press P to take a plate
    // Press H to take some bread
    // he need a plate to take some bread
    // press x to realese
    public Animator doorOpening;
    public Animator grabBread;
    public Animator grabPlate;

    private bool test = false;
    private bool front = false;
    private bool plate = false;
    public bool havePlate = false;


    public void OnTriggerEnter(Collider other)
    {
        print("You're in front of the pantry! Press N to open it.");
        test = true;
    }

    public void OnTriggerExit(Collider other)
    {
        doorOpening.SetBool("isOpen_Obj_1", false);
        test = false;
        front = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            if (Input.GetKey(KeyCode.N))
            {
                doorOpening.SetBool("isOpen_Obj_1", true);
                front = true;
            }
            if (front) {
                print("Press P to grab plate");
                if (Input.GetKey(KeyCode.P))
                {
                    grabPlate.SetBool("grabPlate", true);
                    plate = true;
                    havePlate = true;
                }
            }
            if (plate)
            {
                print("Press H to grab some bread");
                if (Input.GetKey(KeyCode.H))
                {
                    grabBread.SetBool("grabBread", true);
                }
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            grabBread.SetBool("grabBread", false);
            grabPlate.SetBool("grabPlate", false);
            plate = false;
            havePlate = false;
        }
    }

    
}
