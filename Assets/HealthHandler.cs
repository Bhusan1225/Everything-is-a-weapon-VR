using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthHandler : MonoBehaviour
{
    private const float Max_Health = 100f;
    public float health = Max_Health;
    private Image enemyHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthBar = GetComponent<Image>();

    }

    void DecreaseHealth(float decreaseHealth)
    {
        float EnemyHeath = enemyHealthBar.fillAmount;
        EnemyHeath = health / Max_Health;

        EnemyHeath -= decreaseHealth;
    }

    void IncreaseHealth(float IncreaseHealth)
    {
        float EnemyHeath = enemyHealthBar.fillAmount;
        EnemyHeath = health / Max_Health;

        EnemyHeath += IncreaseHealth;
    }
}
