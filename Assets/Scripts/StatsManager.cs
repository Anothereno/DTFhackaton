using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private int maxHealth;
    
    
    [SerializeField] private int money;

    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void AddHealth(int health)
    {
        if (this.health + health > maxHealth)
            this.health = maxHealth;
        else
            this.health += health;
    }

    public void SubHealth(int health)
    {
        if (this.health - health < 0)
            this.health = 0;
        else
            this.health -= health;
    }
    
    public int GetMoney()
    {
        return health;
    }

    public void SetMoney(int money)
    {
        this.money = money;
    }
}
