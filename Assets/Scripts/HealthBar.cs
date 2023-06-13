using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public HealthBar healthBar;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
    public void TakeDamage(int damage)
    {
     //   currentHealth -= damage;

      //  healthBar.SetHealth(currentHealth);
    }
}