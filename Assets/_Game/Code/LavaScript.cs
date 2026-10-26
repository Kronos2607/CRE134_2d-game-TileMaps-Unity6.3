using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public PlayerHealth Phealth;
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("Player"))
        {
            Phealth.Health -= damage;
           
           
        }
    }
}
