using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static score instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        // Başlangıçta skorları güncelle
        _score = 0;  // Başlangıç skoru 0
        _currentScoreText.text = _score.ToString();

        // PlayerPrefs'ten yüksek skoru al
        int highScore = PlayerPrefs.GetInt("HighScore", 0);  // Eğer yoksa varsayılan 0 döner
        _highScoreText.text = highScore.ToString();
    }

    private void UpdateHighScore()
    {
        // Eğer mevcut skor, saklanan yüksek skor ile karşılaştırıldığında daha büyükse
        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            // Yeni yüksek skoru kaydet
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        // Skoru arttır
        _score++;

        // Ekrandaki skoru güncelle
        _currentScoreText.text = _score.ToString();

        // Yüksek skoru güncelle
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        // Burada ekstra bir şey yapmaya gerek yok
    }
}
