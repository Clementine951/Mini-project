using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantyFront : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        print("You're in front of the pantry! Press N and come closer to open it.");
    }
}
