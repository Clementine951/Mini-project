using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDetect : MonoBehaviour
{
    // The caracter grab a new burger when press B
    public Animator GrabIngredient;
    private bool test = false;

    public void OnTriggerEnter(Collider other)
    {
        print("Press B and to grab the burger");
        test = true;
    }

    public void OnTriggerExit(Collider other)
    {
        test = false;
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
            if (Input.GetKey(KeyCode.B))
            {
                GrabIngredient.SetBool("grab", true);
            }
        }
        if (Input.GetKey(KeyCode.X))
        {
            GrabIngredient.SetBool("grab", false);
        }
    }

} // Works Grab burger
