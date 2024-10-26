using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceCanvas : MonoBehaviour
{

    public Animator FX;

    public GameObject PlayerAvatar;

    public Button BTN_A;
    public Button BTN_B;

    void OnEnable()
    {

        if (GameData.ChoiceState == 0)
        {

            //modifica o texto do botao 1 e do btn 2

        }



            BTN_A.onClick.AddListener(BTN_A_CLICK);
        BTN_B.onClick.AddListener(BTN_B_CLICK);



    }

    void OnDisable()
    {
        BTN_A.onClick.RemoveListener(BTN_A_CLICK);
        BTN_B.onClick.RemoveListener(BTN_B_CLICK);
    }


    void BTN_A_CLICK()
    {
        if (GameData.ChoiceState == 0)
        {

            FX.Play("FX_bad");
            GameData.badKarma += 1;
            gameObject.SetActive(false);
            PlayerAvatar.SetActive(true);
        }


        if (GameData.ChoiceState == 1)
        {
        }

        }

        void BTN_B_CLICK()
    {
        if (GameData.ChoiceState == 0)
        {


            FX.Play("FX_good");
            GameData.goodKarma += 1;
            gameObject.SetActive(false);
            PlayerAvatar.SetActive(true);

          
        }

    }

}
