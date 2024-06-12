using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Health : MonoBehaviour
{
    public C_HealthData healthData;
    private C_lives playerLives;

    void Start()
    {
        if (healthData != null)
        {
            healthData.ResetHealth();
            healthData.ResetLives();
        }

        playerLives = GetComponent<C_lives>();
    }

    private void Update()
    {
        RegenerateHealth();
    }

    public void TakeDamage(int damageAmount)
    {
        if (healthData != null)
        {
            healthData.TakeDamage(damageAmount);
            Debug.Log($"Player took {damageAmount} damage, current health: {healthData.currentHealth}");

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

        if (healthData != null)
        {
            if (!healthData.OutOfLives())
            {
                healthData.ResetHealth();
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
            }
        }
    }

}
