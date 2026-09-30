using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<int, int> OnHp;
    public event Action Ondie;
    [SerializeField] int maxHp = 100;
    public int currentHp;
    void Start()
    {
        currentHp = maxHp;
        OnHp?.Invoke(currentHp, maxHp);
    }
    public void TakeDamage(int damage)
    {
        currentHp = Mathf.Max(currentHp - damage, 0);
        OnHp?.Invoke(currentHp, maxHp);
        if (currentHp == 0)
        {
            Ondie?.Invoke();
        }
    }

}
