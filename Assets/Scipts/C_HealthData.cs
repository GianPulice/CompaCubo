using UnityEngine;

[CreateAssetMenu(fileName = "NewHealthData", menuName = "Health Data", order = 51)]
public class C_HealthData : ScriptableObject
{ 

        public int maxHealth = 100;
        public int currentHealth;
        public int maxLives = 3;
        public int currentLives;
        public int healthRegenAmount = 2;
        public float healthRegenInterval = 1f;

        public void ResetHealth()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }

        public bool IsDead()
        {
            return currentHealth <= 0;
        }

        public void LoseLife()
        {
            currentLives--;
        }

        public bool OutOfLives()
        {
            return currentLives <= 0;
        }

        public void ResetLives()
        {
            currentLives = maxLives;
        }
}