using UnityEngine;

public class PlayerHealthTest : MonoBehaviour
{
    public HealthBar healthBar; // Referencia a la barra de vida
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        healthBar.SetHealth(currentHealth);
    }
}
