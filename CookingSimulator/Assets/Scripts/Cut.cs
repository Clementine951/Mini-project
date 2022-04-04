using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private bool trig = false;
    private bool cut = false;
    public Animator TomatoCut;
    public Animator Tomato;
    public Animator SliceTomato;
    public Animator CheeseCut;
    public Animator Cheese;
    public Animator SliceCheese;
    public FridgeDoor frD;

    public bool cheese = false;
    public bool tomato = false;

    public GameObject text;

    public void OnTriggerEnter(Collider other)
    {
        trig = true;

    }


    public void OnTriggerExit(Collider other)
    {
        trig = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        if (trig)
        {
            if (frD.tomato)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press C to cut a tomato";

                if (Input.GetKey(KeyCode.C))
                {
                    Tomato.SetBool("Tomato", false);
                    TomatoCut.SetBool("TomatoCut", true);
                    cut = true;
                    StartCoroutine(ExecuteAfterTime(4));
                }
            }

            if (frD.cheese)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press C to cut cheese";
                if (Input.GetKey(KeyCode.C))
                {
                    Cheese.SetBool("Cheese", false);
                    CheeseCut.SetBool("CheeseCut", true);
                    cut = true;
                    StartCoroutine(ExecuteAfterTimeCheese(4));

                }
            }

            if (cut)
            {
                if (Input.GetKey(KeyCode.T))
                {
                    TomatoCut.SetBool("TomatoCut", false);
                    SliceTomato.SetBool("slice", true);
                    tomato = true;
                }
                if (Input.GetKey(KeyCode.F))
                {
                    CheeseCut.SetBool("CheeseCut", false);
                    SliceCheese.SetBool("sliceC", true);
                    cheese = true;
                }
            }
        }
        if (Input.GetKey(KeyCode.X))
        {
            SliceCheese.SetBool("sliceC", false);
            SliceTomato.SetBool("slice", false);
            tomato = false;
            cheese = false;

        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        text.GetComponent<UnityEngine.UI.Text>().text = "Press T to grab your cut tomato";
    }

    IEnumerator ExecuteAfterTimeCheese(float time)
    {
        yield return new WaitForSeconds(time);
        text.GetComponent<UnityEngine.UI.Text>().text = "Press F to grab your cut cheese";
    }

}
