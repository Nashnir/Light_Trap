using UnityEngine;

public class Supply : MonoBehaviour
{
    [SerializeField] public bool isCollected = false;

    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isCollected = true;
            sprite.enabled = false;
        }
    }
}
