using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public int damage = 10;
    public //PlayerHealth Phealth


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("Player"))
        {
            //Phealth.damage(amount)
        }
    }
}
