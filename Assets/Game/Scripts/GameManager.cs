using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character PlayerCharacter;
    private bool gameIsOver;

    private void Awake()
    {
        PlayerCharacter = GameObject.FindWithTag("Player").GetComponent<Character>();
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER");
    }

    public void GameIsFinished()
    {
        Debug.Log("GAME IS FINISHED");
    }

    private void Update()
    {
        if (gameIsOver)
            return;

        if (PlayerCharacter.CurrentState == Character.CharacterState.Dead)
        {
            gameIsOver = true;
            GameOver();
        }
    }
}

