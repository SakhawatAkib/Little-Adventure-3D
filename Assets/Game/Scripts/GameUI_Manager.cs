using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI_Manager : MonoBehaviour
{
    public GameManager GM;
    public TextMeshProUGUI CoinText;
    public Slider HealthSlider;
    public GameObject UI_Pause;
    public GameObject UI_GameOver;
    public GameObject UI_GameIsFinished;
    public AudioSource bgAudioSource;

    private enum GameUI_State
    {
        GamePlay, Pause, GameOver, GameIsFinished
    }

    private GameUI_State currentState;

    private void Start()
    {
        SwitchUIState(GameUI_State.GamePlay);
    }

    private void Update()
    {
        HealthSlider.value = GM.PlayerCharacter.GetComponent<Health>().CurrentHealthPercentage;
        CoinText.text = GM.PlayerCharacter.Coin.ToString();
    }

    private void SwitchUIState(GameUI_State state)
    {
        UI_Pause.SetActive(false);
        UI_GameOver.SetActive(false);
        UI_GameIsFinished.SetActive(false);

        Time.timeScale = 1;

        switch (state)
        {
            case GameUI_State.GamePlay:
                bgAudioSource.Play();
                break;
            case GameUI_State.Pause:
                Time.timeScale = 0;
                UI_Pause.SetActive(true);
                bgAudioSource.Stop();
                break;
            case GameUI_State.GameOver:
                bgAudioSource.Stop();
                UI_GameOver.SetActive(true);
                break;
            case GameUI_State.GameIsFinished:
                bgAudioSource.Stop();
                UI_GameIsFinished.SetActive(true);
                break;
        }

        currentState = state;
    }

    public void TogglePauseUI()
    {
        if(currentState == GameUI_State.GamePlay)
            SwitchUIState(GameUI_State.Pause);
        else if(currentState == GameUI_State.Pause)
            SwitchUIState(GameUI_State.GamePlay);
    }

    public void Button_MainMenu()
    {
        GM.ReturnToTheMainMenu();
    }

    public void Button_Restart()
    {
        GM.Restart();
    }

    public void ShowGameOverUI()
    {
        SwitchUIState(GameUI_State.GameOver);
    }

    public void ShowGameIsFinishedUI()
    {
        SwitchUIState(GameUI_State.GameIsFinished);
    }
}

