using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;  // Ref al ui 

    public UnityEvent onDeath;

    void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetHealth(currentHealth);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
            currentHealth = 0;

        if (healthBar != null)
            healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
            Die();
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        if (healthBar != null)
            healthBar.SetHealth(currentHealth);
    }

    private void Die()
    {
        Debug.Log("Player murió");
        onDeath?.Invoke();
    }
}
