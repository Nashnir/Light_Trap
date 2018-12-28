using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Supply[] supplies;

    // Start is called before the first frame update
    void Start()
    {
        supplies = FindObjectsOfType<Supply>();
    }

    bool CheckSupplyIsCollected() {
        bool allSuppliesCollected = true;

        foreach (Supply supply in supplies)
        {
            if (!supply.isCollected)
            {
                allSuppliesCollected = false;
                break;
            }
        }

        return allSuppliesCollected;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (CheckSupplyIsCollected())
            {
                GameManager.instance.ReloadScene();
            }
        }
    }
}
