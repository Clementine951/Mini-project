using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Realese : MonoBehaviour
{
    public PantryDoors pantryD;
    public FridgeDoor fridgeD;
    public Cut cut;
    public Pan pan;
    public IngredientDetect inD;

    public GameObject plate;
    public GameObject bread;
    public GameObject bread1;
    public GameObject salad;
    public GameObject tomato;
    public GameObject cheese;
    public GameObject steak;
    public GameObject burger;
    public GameObject text;

    private bool trig = false;
    private bool br = false;
    private bool sa = false;
    private bool to = false;
    private bool ch = false;
    private bool st = false;
    private bool pl = false;

    public bool bur = false;


    // Detection zone for the left of the table

    public void OnTriggerEnter(Collider other)
    {
        trig = true;
    }

    public void OnTriggerExit(Collider other)
    {
        trig = false;
    }

    private void Awake()
    {
        plate.SetActive(false);
        bread.SetActive(false);
        bread1.SetActive(false);
        salad.SetActive(false);
        tomato.SetActive(false);
        cheese.SetActive(false);
        steak.SetActive(false);
        burger.SetActive(false);
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
            if (pantryD.havePlate)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    pantryD.grabPlate.SetBool("grabPlate", false);
                    plate.SetActive(true);
                    pl = true;
                }
            }

            if (pantryD.haveBread)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    pantryD.grabBread.SetBool("grabBread", false);
                    plate.SetActive(true);
                    bread.SetActive(true);
                    bread1.SetActive(true);
                    br = true;
                    //if (pl)
                    //{
                    //    pantryD.grabPlate.SetBool("grabPlate", true);
                    //}
                }
            }
            if (fridgeD.salad)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    fridgeD.grabSalad.SetBool("Salad", false);
                    plate.SetActive(true);
                    salad.SetActive(true);
                    sa = true;
                    //if (pl)
                    //{
                    //    pantryD.grabPlate.SetBool("grabPlate", true);
                    //}
                }
            }
            if (cut.tomato)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    cut.SliceTomato.SetBool("slice", false);
                    plate.SetActive(true);
                    tomato.SetActive(true);
                    to = true;
                    //if (pl)
                    //{
                    //    pantryD.grabPlate.SetBool("grabPlate", true);
                    //}
                }
            }
            if (cut.cheese)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    cut.SliceCheese.SetBool("sliceC", false);
                    plate.SetActive(true);
                    cheese.SetActive(true);
                    ch = true;
                    //if (pl)
                    //{
                    //    pantryD.grabPlate.SetBool("grabPlate", true);
                    //}
                }
            }
            if (pan.haveSteak)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Press M to realease";
                if (Input.GetKey(KeyCode.M))
                {
                    pan.GrabCookedSteak.SetBool("CookedSteak", false);
                    plate.SetActive(true);
                    steak.SetActive(true);
                    st = true;
                    //if (pl)
                    //{
                    //    pantryD.grabPlate.SetBool("grabPlate", true);
                    //}
                }
            }
            if (Input.GetKey(KeyCode.X))
            {
                plate.SetActive(false);
                bread.SetActive(false);
                bread1.SetActive(false);
                salad.SetActive(false);
                tomato.SetActive(false);
                cheese.SetActive(false);
                steak.SetActive(false);
                bur = false;
            }

            if (br & sa & to & ch & st)
            {
                plate.SetActive(true);
                bread.SetActive(false);
                bread1.SetActive(false);
                salad.SetActive(false);
                tomato.SetActive(false);
                cheese.SetActive(false);
                steak.SetActive(false);

                burger.SetActive(true);

                pantryD.grabPlate.SetBool("grabPlate", false);

                text.GetComponent<UnityEngine.UI.Text>().text = "Press B to take the burger";
                if (Input.GetKey(KeyCode.B))
                {
                    inD.GrabIngredient.SetBool("grab", true);
                    burger.SetActive(false);
                    plate.SetActive(false);
                    bur = true;
                }
            }
        }
    }
}
