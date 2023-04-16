using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : Entity
{
    [SerializeField] private int lives = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            lives--;
            Debug.Log("У лягушки " + lives);
        }
        if (lives <= 0)
            Die();
    }
}
