using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantryDoors : MonoBehaviour
{
    // The caracter open the pantry when press N
    // Press P to take a plate
    // Press B to take some bread
    // he need a plate to take some bread
    // press x to realese
    public Animator doorOpening;
    public Animator grabBread;
    public Animator grabPlate;

    private bool test = false;
    private bool front = false;
    public bool havePlate = false;
    public bool haveBread = false;

    public GameObject text;


    public void OnTriggerEnter(Collider other)
    {
        text.GetComponent<UnityEngine.UI.Text>().text = "You're in front of the pantry! Press N to open it.";
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
                text.GetComponent<UnityEngine.UI.Text>().text = "Press P to grab plate";
                if (Input.GetKey(KeyCode.P))
                {
                    grabPlate.SetBool("grabPlate", true);
                    havePlate = true;
                }
            }
            if (havePlate)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press B to grab some bread";
                if (Input.GetKey(KeyCode.B))
                {
                    grabPlate.SetBool("grabPlate", false);
                    grabBread.SetBool("grabBread", true);
                    haveBread = true;
                }
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            grabBread.SetBool("grabBread", false);
            grabPlate.SetBool("grabPlate", false);
            havePlate = false;
            haveBread = false;
        }
    }

    
}
