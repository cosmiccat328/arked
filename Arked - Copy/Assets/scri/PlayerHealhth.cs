using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealhth : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentHealth, maxHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dealDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
