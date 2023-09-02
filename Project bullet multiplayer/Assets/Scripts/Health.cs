using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool destroyOnNoHealth = false;
    // private DamageNumberSpawner damageNumberSpawner;
    public Boolean showDamage = false;
    // public float damageInterval = 0.5f;
    public Image healthUI;

    public UnityEvent damageNumberTrigger;

    private void DamageNumber()
    {
        // Invoke the UnityEvent when needed
        damageNumberTrigger.Invoke();
    }

    private void Awake()
    {
        currentHealth = maxHealth;
        // damageNumberSpawner = GetComponent<DamageNumberSpawner>();
    }

    private void OnEnable()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {

            if (destroyOnNoHealth == true) Destroy(this.gameObject);
            if (destroyOnNoHealth == false) gameObject.SetActive(false);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        UpdateHealthUI();

        // if (damageNumberSpawner) InitializeSpawnDamage(damage.ToString());

    }

    private void InitializeSpawnDamage(string damageText = "N/A")
    {
        // damageNumberSpawner.SpawnDamage(damageText);
    }

    private void UpdateHealthUI()
    {
        if (healthUI == null) return;
        // Convert max health to 1
        // Debug.Log((float)currentHealth / (float)maxHealth);
        healthUI.fillAmount = (float)currentHealth / (float)maxHealth;
    }

}
