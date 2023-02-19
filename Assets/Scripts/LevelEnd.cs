using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public GameObject winMessage;

    private void Start()
    {
        winMessage.SetActive(false);
    }

    int playerLayer = 3;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //cuando se toca el banderin
        if (collision.gameObject.layer == playerLayer)
        {
            //activa EndLevel
            StartCoroutine(EndLevel());
        }
    }
    IEnumerator EndLevel()
    {
        //para el tiempo
        Time.timeScale = 0f;
        //haz visible el texto
        winMessage.SetActive(true);
        //esperar 5 segundos
        yield return new WaitForSecondsRealtime(2f);
        //vuelve al menu principal
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
