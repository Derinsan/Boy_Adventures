using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class PlayerTouch : MonoBehaviour
    {
        public static int bronzeCoin;
        public static int silverCoin;
        public static int goldCoin;
        [SerializeField] private GameObject _panelLevelOver;
        public static int bronzeCoinMax;
        public static int silverCoinMax;
        public static int goldCoinMax;
        

        private void Start()
        {
            bronzeCoin = 0;
            silverCoin = 0;
            goldCoin = 0;
            _panelLevelOver.SetActive(false);
            GameObject[] bronzeCoinsLength = GameObject.FindGameObjectsWithTag("BronzeCoin");
            bronzeCoinMax = bronzeCoinsLength.Length;
            Debug.Log(bronzeCoinMax);
            
            GameObject[] silverCoinsLength = GameObject.FindGameObjectsWithTag("SilverCoin");
            silverCoinMax = silverCoinsLength.Length;
            Debug.Log(silverCoinMax);
            
            GameObject[] goldCoinsLength = GameObject.FindGameObjectsWithTag("GoldCoin");
            goldCoinMax = goldCoinsLength.Length;
            Debug.Log(goldCoinMax);
            
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("BronzeCoin"))
            {
                bronzeCoin++;
                Destroy(other.gameObject);
            }

            if (other.gameObject.CompareTag("SilverCoin"))
            {
                silverCoin++;
                Destroy(other.gameObject);
            }

            if (other.gameObject.CompareTag("GoldCoin"))
            {
                goldCoin++;
                Destroy(other.gameObject);
            }

            if (other.gameObject.CompareTag("Finish"))
            {
                _panelLevelOver.SetActive(true);
            }

            if (other.gameObject.name == "FinishLevel1")
            {
                LevelsControl.LevelsComplete[0] = 1;
                PlayerPrefs.SetInt("LevelComplete1", 1);
            }
            if (other.gameObject.name == "FinishLevel2")
            {
                LevelsControl.LevelsComplete[1] = 1;
                PlayerPrefs.SetInt("LevelComplete2", 1);
            }
            if (other.gameObject.name == "FinishLevel3")
            {
                LevelsControl.LevelsComplete[2] = 1;
                PlayerPrefs.SetInt("LevelComplete3", 1);
            }
            if (other.gameObject.name == "FinishLevel4")
            {
                LevelsControl.LevelsComplete[3] = 1;
                PlayerPrefs.SetInt("LevelComplete4", 1);
            }
            if (other.gameObject.name == "FinishLevel5")
            {
                LevelsControl.LevelsComplete[4] = 1;
                PlayerPrefs.SetInt("LevelComplete5", 1);
            }
            if (other.gameObject.name == "FinishLevel6")
            {
                LevelsControl.LevelsComplete[5] = 1;
                PlayerPrefs.SetInt("LevelComplete6", 1);
            }
            if (other.gameObject.name == "FinishLevel7")
            {
                LevelsControl.LevelsComplete[6] = 1;
                PlayerPrefs.SetInt("LevelComplete7", 1);
            }
            if (other.gameObject.name == "FinishLevel8")
            {
                LevelsControl.LevelsComplete[7] = 1;
                PlayerPrefs.SetInt("LevelComplete8", 1);
            }
            if (other.gameObject.name == "FinishLevel9")
            {
                LevelsControl.LevelsComplete[8] = 1;
                PlayerPrefs.SetInt("LevelComplete9", 1);
            }
            if (other.gameObject.name == "FinishLevel10")
            {
                LevelsControl.LevelsComplete[9] = 1;
                PlayerPrefs.SetInt("LevelComplete10", 1);
            }
            if (other.gameObject.name == "FinishLevel11")
            {
                LevelsControl.LevelsComplete[10] = 1;
                PlayerPrefs.SetInt("LevelComplete11", 1);
            }
            if (other.gameObject.name == "FinishLevel12")
            {
                LevelsControl.LevelsComplete[11] = 1;
                PlayerPrefs.SetInt("LevelComplete12", 1);
            }
        }
    }
}