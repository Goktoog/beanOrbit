using UnityEngine;

public class TiledBackground : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private float _width = 100f; // Background'un genişliği
    private SpriteRenderer _spriteRenderer;
    private Vector2 _startPosition;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startPosition = transform.position;
    }

    private void Update()
    {
        // Background'u sola kaydırma
        float newXPosition = Mathf.Repeat(Time.time * _speed, _width);
        transform.position = _startPosition + Vector2.left * newXPosition;
    }
}
