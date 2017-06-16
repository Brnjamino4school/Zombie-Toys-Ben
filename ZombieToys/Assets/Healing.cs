using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public int healingAmount ;
    public GameObject healthpack;
    public int health;
    int max = 100;
    private void Awake()
    {
        int max = GameManager.Instance.Player.maxHealth;
        healingAmount = healingAmount * -1;
    }
    private void Update()
    {
        health = GameManager.Instance.Player.currentHealth;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        health = GameManager.Instance.Player.currentHealth;
        if (health == max)
        {
            return;
        }
        else {
            if (health < max + healingAmount)
            {
                GameManager.Instance.Player.TakeDamage(healingAmount);
                healthpack.SetActive(false);
                /*    if (GameManager.Instance.Player.healthSlider != null)
                    {
                        GameManager.Instance.Player.healthSlider.value = health / (float)GameManager.Instance.Player.maxHealth;
                    }*/
            }
            else if (health > max + healingAmount)
            {

                GameManager.Instance.Player.TakeDamage((-1)*(100-health));
                healthpack.SetActive(false);
                /*if (GameManager.Instance.Player.healthSlider != null) {
                    GameManager.Instance.Player.healthSlider.value = health / (float)GameManager.Instance.Player.maxHealth;
                }
                */
            }
        }
    }
	}
