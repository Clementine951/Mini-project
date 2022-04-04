using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Pan : MonoBehaviour
{
    // put a steak uncooked on the pan
    // after 30s the steak is cooked
    // after 70s the steak burn
    public Animator PanSteak;
    public Animator GrabCookedSteak;
    public FridgeDoor frD;
    public bool inFrontOfPan = false;
    private bool steakCooked = false;
    private bool steakBurned = false;
    private bool grabAfterBurned = true;

    public bool haveSteak;

    public GameObject text;

    public void OnTriggerEnter(Collider other)
    {
        inFrontOfPan = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inFrontOfPan = false;
    }

    void Start()
    {

    }

    void Update()
    {
        if (frD.steak) // If you have a steak
        {
            if (inFrontOfPan) // If you are in front of the pan
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press S to put your steak in the pan";

                if (Input.GetKey(KeyCode.S))
                {
                    PanSteak.SetBool("FrontStove", true);
                    StartCoroutine(ExecuteAfterTime(30));
                    if (grabAfterBurned)
                    {
                        StartCoroutine(ExecuteAfterTime2(70));
                    }
                }
                if (steakCooked)
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = "Press G to take your steak before it burns!";

                    if (Input.GetKey(KeyCode.G))
                    {
                        grabAfterBurned = false;
                        PanSteak.SetBool("FrontStove", false);
                        GrabCookedSteak.SetBool("CookedSteak", true);
                        haveSteak = true;

                    }
                }
                if (Input.GetKey(KeyCode.X))
                {
                    GrabCookedSteak.SetBool("CookedSteak", false);
                    haveSteak = false;
                }
                if (steakBurned)
                {
                    if (Input.GetKey(KeyCode.X))
                    {
                        PanSteak.SetBool("FrontStove", false);
                    }
                }
            }
        }
        
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        text.GetComponent<UnityEngine.UI.Text>().text = "Your steak is cooked!";

        steakCooked = true;
    }

    IEnumerator ExecuteAfterTime2(float time)
    {
        yield return new WaitForSeconds(time);

        text.GetComponent<UnityEngine.UI.Text>().text = "Your steak is burning!";
        steakCooked = false;
        steakBurned = true;
        grabAfterBurned = true;
    }

}


