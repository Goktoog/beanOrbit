using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton yapısı
    public static GameManager instance;

    // UI elementleri
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _gameTitleCanvas;
    [SerializeField] private GameObject _playButton;

    // Oyun durumları
    public enum GameState { Menu, Playing, GameOver }
    public GameState currentGameState;

    private void Awake()
    {
        // Singleton yapısı
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        // Başlangıçta oyun menüsü durumuna geç
        SetGameState(GameState.Menu);

        // Başlangıçta UI durumunu ayarla
        _gameTitleCanvas.SetActive(true);
        _playButton.SetActive(true);
        _gameOverCanvas.SetActive(false);

        // Oyunun hızını durdur
        Time.timeScale = 0f;
    }

    public void PlayButtonClicked()
    {
        // Oyun durumu kontrolü
        if (currentGameState == GameState.Menu)
        {
            StartGame(); // Eğer menüdeysek oyunu başlat
        }
        else if (currentGameState == GameState.GameOver)
        {
            RestartGame(); // Eğer Game Over ekranındaysak oyunu yeniden başlat
        }
    }

    public void StartGame()
    {
        // Oyun durumunu Playing'e ayarla
        SetGameState(GameState.Playing);

        // UI elemanlarını gizle
        _gameTitleCanvas.SetActive(false);
        _playButton.SetActive(false);

        // Game Over Canvas'ı gizle
        _gameOverCanvas.SetActive(false);

        // Oyunu başlat
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        // Oyun durumunu GameOver'a ayarla
        SetGameState(GameState.GameOver);

        // Game Over ekranını ve Play Button'u aktif yap
        _gameOverCanvas.SetActive(true);
        _playButton.SetActive(true);

        // Zaman ölçeğini durdur
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void SetGameState(GameState newState)
    {
        currentGameState = newState;
    }
}
