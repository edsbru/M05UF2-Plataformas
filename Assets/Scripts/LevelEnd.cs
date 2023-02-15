using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public GameObject winMessage;
    bool showingMessage = false;
    float showingMessageTimeCount = 0f;
    float showingMessageTimeDuration = 4f;

    private void Start()
    {
        winMessage.SetActive(false);
    }

    private void Update()
    {
        if (showingMessage)
        {
            showingMessageTimeCount += Time.deltaTime;
            if(showingMessageTimeCount >= showingMessageTimeDuration)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }

        }
    }

    int playerLayer = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == playerLayer)
        {
            EndLevel();
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }

    void EndLevel()
    {
        showingMessage = true;
        Time.timeScale = 0f;
        winMessage.SetActive(true);
    }
}
