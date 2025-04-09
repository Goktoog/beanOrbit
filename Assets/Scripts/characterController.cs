using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class characterController : MonoBehaviour
{
    [SerializeField] private float _velocity = 3;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D _rb;
    private AudioSource _audioSource;
    public ParticleSystem explosionEffect;



    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>(); 

    }

    // Update is called once per frame
    void Update()
    {
        // Sadece oyun Playing durumundaysa karakter hareket etsin
        if (GameManager.instance.currentGameState != GameManager.GameState.Playing)
            return;

        if (Input.GetMouseButtonUp(0)) // 0: Sol tık, 1: Sağ tık, 2: Orta tık için geçerlidir.
        {
            _rb.velocity = Vector2.up * _velocity;
        }
    }
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (explosionEffect != null)
        {
            explosionEffect.transform.position = transform.position;
            explosionEffect.Play(); // Patlama efektini çalıştır
        }

        GameManager.instance.GameOver();
        if (_audioSource != null && !_audioSource.isPlaying) // AudioSource atanmış mı ve zaten çalmıyor mu kontrol et
        {
            _audioSource.Play(); // Ölüm sesini çal
        }

    }
}
