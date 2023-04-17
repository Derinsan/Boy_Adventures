using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace UI
{
    public class MenuButton : MonoBehaviour
    {
        public int isFirstGame;

        private void Start()
        {
            isFirstGame = PlayerPrefs.GetInt("IsFirstGame");
            if (isFirstGame == 0)
            {
                SceneManager.LoadScene("Tutorial");
                PlayerPrefs.SetInt("IsFirstGame", 1);
            }
        }

        public void PlayButton()
        {
            SceneManager.LoadScene("Scenes/SelectionLevel");
        }

        public void ExitGameButton()
        {
            Application.Quit();
        }

        public void HomeButton()
        {
            SceneManager.LoadScene("Menu");
        }

        public void DeletePlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}