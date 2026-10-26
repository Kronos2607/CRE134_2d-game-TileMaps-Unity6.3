using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;

    private int Health;

    public float MaxHealth = 3;
    public float MinHealth = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Health--;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Health++;
        }

        switch (Health) 
        {
            case 0:
                {
                    Health1.gameObject.SetActive(false);
                    Health2.gameObject.SetActive(false);
                    Health3.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    Health1.gameObject.SetActive(true);
                    Health2.gameObject.SetActive(false);
                    Health3.gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    Health1.gameObject.SetActive(true);
                    Health2.gameObject.SetActive(true);
                    Health3.gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    Health1.gameObject.SetActive(true);
                    Health2.gameObject.SetActive(true);
                    Health3.gameObject.SetActive(true);
                    break;
                }
        }
    }
}
