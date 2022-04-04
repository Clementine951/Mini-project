using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoeffeTable : MonoBehaviour
{
    public GameObject burger;
    public GameObject text;

    public Realese rea;
    public Realese rea1;
    public Realese rea2;
    public Realese rea3;
    public IngredientDetect inD;

    private void Awake()
    {
        burger.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rea.bur | rea1.bur | rea2.bur | rea3.bur)
        {
            //print("Press B to put the burger on the coffee table");
            text.GetComponent<UnityEngine.UI.Text>().text = "Press B to put the burger on the coffee table";
            if (Input.GetKey(KeyCode.B))
            {
                inD.GrabIngredient.SetBool("grab", true);
                burger.SetActive(true);
            }
        }
    }
}
