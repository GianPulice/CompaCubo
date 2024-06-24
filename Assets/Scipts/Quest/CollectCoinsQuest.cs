using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CollectCoinsQuest", menuName = "Quests/Collect Coins Quest")]
public class CollectCoinsQuest : Quest
{
    public int requiredCoins;
    private int currentCoins;

    public void AddCoin()
    {
        currentCoins++;
    }

    public override bool IsCompleted()
    {
        return currentCoins >= requiredCoins;
    }

    public override float GetCompletionPercentage()
    {
        return (float)currentCoins / requiredCoins * 100f;
    }
}