using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class C_lives : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public C_HealthData healthData;

    void Start()
    {
        if (healthData != null)
        {
            healthData.ResetLives();
            UpdateLivesUI();
        }
    }

    public void DecreaseLives()
    {
        if (healthData != null)
        {
            healthData.LoseLife();
            //UpdateLivesUI();
            UI_Updater.Instance.LoseLife.Invoke();
            if (healthData.OutOfLives())
            {
                SceneManager.LoadScene("derrota");
            }
        }
    }

    public void UpdateLivesUI()
    {
        if (textMeshPro != null && healthData != null)
        {
            textMeshPro.text = $"{healthData.currentLives}";
        }
    }
}
