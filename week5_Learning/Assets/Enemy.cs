using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        // if (other.gameObject.GetComponent<Player>())
        {
            player.TakeDamage(damage);
        }
    }
}
