using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleReward : MonoBehaviour
{
    public static BattleReward instance;
    
    public GameObject rewardScreen;
    public TMP_Text xpText, itemText;

    public string[] rewardItems;
    public int xpEarned;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            OpenRewardScreen(100, new string[] { "Iron Sword", "Iron Armor" });
        }
    }

    public void OpenRewardScreen(int xp, string[] rewards)
    {
        xpEarned = xp;
        rewardItems = rewards;

        xpText.text = "Zdobyto " + xpEarned + " XP!";
        itemText.text = "";

        for(int i = 0; i < rewardItems.Length; i++)
        {
            itemText.text += rewards[i] + "\n";
        }

        rewardScreen.SetActive(true);
    }

    public CloseRewardScreen()
    {

    }
}
