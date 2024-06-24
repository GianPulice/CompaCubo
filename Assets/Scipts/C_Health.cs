using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Health : MonoBehaviour
{
    public C_HealthData healthData;
    private C_lives playerLives;
    private C_CheckPoint checkPoint;

    void Start()
    {
        if (healthData != null)
        {
            healthData.ResetHealth();
            healthData.ResetLives();
            StartCoroutine(RegenerateHealth()); 
        }

        playerLives = GetComponent<C_lives>();
        checkPoint = GetComponent<C_CheckPoint>();
    }

    public void TakeDamage(int damageAmount)
    {
        if (healthData != null)
        {
            healthData.TakeDamage(damageAmount);
            Debug.Log($"{damageAmount} damage, current health: {healthData.currentHealth}");

            UI_Updater.Instance.UpdateHealth.Invoke();

            if (healthData.IsDead())
            {
                Die();
            }
        }
    }

    private void Die()
    {
        Debug.Log("Player died");

        if (playerLives != null)
        {
            playerLives.DecreaseLives();
        }

        if (healthData != null && checkPoint != null)
        {
            if (!healthData.OutOfLives())
            {
                healthData.ResetHealth();
                UI_Updater.Instance.UpdateHealth.Invoke();
                checkPoint.Respawn();
            }
        }
    }

    private IEnumerator RegenerateHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(healthData.healthRegenInterval);

            if (healthData.currentHealth < healthData.maxHealth)
            {
                healthData.currentHealth += healthData.healthRegenAmount;
                if (healthData.currentHealth > healthData.maxHealth)
                {
                    healthData.currentHealth = healthData.maxHealth;
                }

                UI_Updater.Instance.UpdateHealth.Invoke();

            }

        }
    }

}
