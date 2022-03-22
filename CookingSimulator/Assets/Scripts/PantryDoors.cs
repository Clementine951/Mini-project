using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantryDoors : MonoBehaviour
{
    // The caracter open the pantry when press N
    public Animator doorOpening;
    public Animator grabBread;
    public Animator grabPlate;

    private bool test = false;
    private bool front = false;
    private bool plate = false;

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
                print("Press H to grab bread");
                print("Press P to grab bread");
                if (Input.GetKey(KeyCode.H))
                {
                    grabBread.SetBool("grabBread", true);
                }
                if (Input.GetKey(KeyCode.P))
                {
                    grabPlate.SetBool("grabPlate", true);
                    plate = true;
                }
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            grabBread.SetBool("grabBread", false);
            grabPlate.SetBool("grabPlate", false);
            plate = false;
        }
    }

    
}
