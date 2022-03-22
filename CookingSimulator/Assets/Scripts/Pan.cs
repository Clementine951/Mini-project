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
    private bool inFrontOfPan = false;
    private bool steakCooked = false;
    private bool steakBurned = false;
    private bool grabAfterBurned = true;

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
        if (inFrontOfPan)
        {
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
                print("Press G to take your steak before it burns! ");

                if (Input.GetKey(KeyCode.G))
                {
                    grabAfterBurned = false;
                    PanSteak.SetBool("FrontStove", false);
                    GrabCookedSteak.SetBool("CookedSteak", true);

                }
            }
            if (Input.GetKey(KeyCode.X))
            {
                GrabCookedSteak.SetBool("CookedSteak", false);
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

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        print("Your steak is cooked!");
        steakCooked = true;
    }

    IEnumerator ExecuteAfterTime2(float time)
    {
        yield return new WaitForSeconds(time);

        print("Your steak is burning!");
        steakCooked = false;
        steakBurned = true;
        grabAfterBurned = true;
    }

}
