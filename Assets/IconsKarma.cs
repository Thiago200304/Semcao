using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsKarma : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bad1;
    public GameObject bad2;
    public GameObject bad3;

    public GameObject good1;
    public GameObject good2;
    public GameObject good3;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (GameData.badKarma == 1)
        {
            bad1.SetActive(true);
        }

        if (GameData.badKarma == 2)
        {
            bad2.SetActive(true);
        }
        if (GameData.badKarma == 3)
        {
            bad3.SetActive(true);
        }
        if (GameData.goodKarma == 1)
        {
            good1.SetActive(true);
        }
        if (GameData.goodKarma == 2)
        {
            good2.SetActive(true);
        }
        if (GameData.goodKarma == 3)
        {
            good3.SetActive(true);
        }
    }
}
