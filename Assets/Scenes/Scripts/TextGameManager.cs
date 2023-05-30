using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storyText;
    public int HpValue, StaminaValue;
    public GameObject Level1Choice;
    public GameObject Level2Choice;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = HpValue.ToString();
        staminaTextMeshPro.text = StaminaValue.ToString();
    }

    public void Leon()
    {
        storyText = "Leon Scott Kennedy is an American of Italian descent currently employed as a federal agent by the Division of Security Operations (D.S.O.), a counter-terrorism agency with direct Presidential oversight.";
        Level1Choice.SetActive(false);
        HpValue = 8;
        Level2Choice.SetActive(false);
    }
    public void Claire()
    {
        storyText = "Claire Redfieldis is a current member of the human rights organization, TerraSave. She is the younger sister of BSAA operative and former S.T.A.R.S. member Chris Redfield.";
        HpValue= 0;

        Level1Choice.SetActive(false);
        Level2Choice.SetActive(false);
    }
    public void Ada()
    {
        storyText = "Ada Wong is the pseudonym of an enigmatic unnamed spy of Asian-American descent.";
        HpValue= 5;

        Level1Choice.SetActive(false);
        Level2Choice.SetActive(false);
    }
}