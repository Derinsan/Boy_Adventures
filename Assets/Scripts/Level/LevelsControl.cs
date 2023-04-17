using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelsControl : MonoBehaviour
{
    [SerializeField] private Button[] _buttonsLevel;
    public static int[] LevelsComplete = {0,0,0,0,0,0,0,0,0,0,0,0};
    [SerializeField] private Sprite _imageCompleteLevel;
    [SerializeField] private Sprite _imageDostupLevel;
    [SerializeField] private TextMeshProUGUI[] _textLevel;

    private void Start()
    {
        LevelsComplete[0] = PlayerPrefs.GetInt("LevelComplete1");
        LevelsComplete[1] = PlayerPrefs.GetInt("LevelComplete2");
        LevelsComplete[2] = PlayerPrefs.GetInt("LevelComplete3");
        LevelsComplete[3] = PlayerPrefs.GetInt("LevelComplete4");
        LevelsComplete[4] = PlayerPrefs.GetInt("LevelComplete5");
        LevelsComplete[5] = PlayerPrefs.GetInt("LevelComplete6");
        LevelsComplete[6] = PlayerPrefs.GetInt("LevelComplete7");
        LevelsComplete[7] = PlayerPrefs.GetInt("LevelComplete8");
        LevelsComplete[8] = PlayerPrefs.GetInt("LevelComplete9");
        LevelsComplete[9] = PlayerPrefs.GetInt("LevelComplete10");
        LevelsComplete[10] = PlayerPrefs.GetInt("LevelComplete11");
        LevelsComplete[11] = PlayerPrefs.GetInt("LevelComplete12");
        
        #region SystemLevels
        if (LevelsComplete[0] != 1)
        {
            _buttonsLevel[1].interactable = false;
            _buttonsLevel[1].image.sprite = _imageDostupLevel;
            _textLevel[1].enabled = false;
        }
        else if (LevelsComplete[0] == 1)
        {
            _buttonsLevel[1].interactable = true;
            _textLevel[0].enabled = false;
            _textLevel[1].enabled = true;
            _buttonsLevel[0].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[1] != 1)
        {
            _buttonsLevel[2].interactable = false;
            _buttonsLevel[2].image.sprite = _imageDostupLevel;
            _textLevel[2].enabled = false;
        }
        else if (LevelsComplete[1] == 1)
        {
            _buttonsLevel[2].interactable = true;
            _textLevel[1].enabled = false;
            _textLevel[2].enabled = true;
            _buttonsLevel[1].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[2] != 1)
        {
            _buttonsLevel[3].interactable = false;
            _buttonsLevel[3].image.sprite = _imageDostupLevel;
            _textLevel[3].enabled = false;
        }
        else if (LevelsComplete[2] == 1)
        {
            _buttonsLevel[3].interactable = true;
            _textLevel[2].enabled = false;
            _textLevel[3].enabled = true;
            _buttonsLevel[2].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[3] != 1)
        {
            _buttonsLevel[4].interactable = false;
            _buttonsLevel[4].image.sprite = _imageDostupLevel;
            _textLevel[4].enabled = false;
        }
        else if (LevelsComplete[3] == 1)
        {
            _buttonsLevel[4].interactable = true;
            _textLevel[3].enabled = false;
            _textLevel[4].enabled = true;
            _buttonsLevel[3].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[4] != 1)
        {
            _buttonsLevel[5].interactable = false;
            _buttonsLevel[5].image.sprite = _imageDostupLevel;
            _textLevel[5].enabled = false;
        }
        else if (LevelsComplete[4] == 1)
        {
            _buttonsLevel[5].interactable = true;
            _textLevel[4].enabled = false;
            _textLevel[5].enabled = true;
            _buttonsLevel[4].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[5] != 1)
        {
            _buttonsLevel[6].interactable = false;
            _buttonsLevel[6].image.sprite = _imageDostupLevel;
            _textLevel[6].enabled = false;
        }
        else if (LevelsComplete[5] == 1)
        {
            _buttonsLevel[6].interactable = true;
            _textLevel[5].enabled = false;
            _textLevel[6].enabled = true;
            _buttonsLevel[5].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[6] != 1)
        {
            _buttonsLevel[7].interactable = false;
            _buttonsLevel[7].image.sprite = _imageDostupLevel;
            _textLevel[7].enabled = false;
        }
        else if (LevelsComplete[6] == 1)
        {
            _buttonsLevel[7].interactable = true;
            _textLevel[6].enabled = false;
            _textLevel[7].enabled = true;
            _buttonsLevel[6].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[7] != 1)
        {
            _buttonsLevel[8].interactable = false;
            _buttonsLevel[8].image.sprite = _imageDostupLevel;
            _textLevel[8].enabled = false;
        }
        else if (LevelsComplete[7] == 1)
        {
            _buttonsLevel[8].interactable = true;
            _textLevel[7].enabled = false;
            _textLevel[8].enabled = true;
            _buttonsLevel[7].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[8] != 1)
        {
            _buttonsLevel[9].interactable = false;
            _buttonsLevel[9].image.sprite = _imageDostupLevel;
            _textLevel[9].enabled = false;
        }
        else if (LevelsComplete[8] == 1)
        {
            _buttonsLevel[9].interactable = true;
            _textLevel[8].enabled = false;
            _textLevel[9].enabled = true;
            _buttonsLevel[8].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[9] != 1)
        {
            _buttonsLevel[10].interactable = false;
            _buttonsLevel[10].image.sprite = _imageDostupLevel;
            _textLevel[10].enabled = false;
        }
        else if (LevelsComplete[9] == 1)
        {
            _buttonsLevel[10].interactable = true;
            _textLevel[9].enabled = false;
            _textLevel[10].enabled = true;
            _buttonsLevel[9].image.sprite = _imageCompleteLevel;
        }
        
        if (LevelsComplete[10] != 1)
        {
            _buttonsLevel[11].interactable = false;
            _buttonsLevel[11].image.sprite = _imageDostupLevel;
            _textLevel[11].enabled = false;
        }
        else if (LevelsComplete[10] == 1)
        {
            _buttonsLevel[11].interactable = true;
            _textLevel[10].enabled = false;
            _textLevel[11].enabled = true;
            _buttonsLevel[10].image.sprite = _imageCompleteLevel;
        }

        if (LevelsComplete[11] == 1)
        {
            _textLevel[11].enabled = false;
            _buttonsLevel[11].image.sprite = _imageCompleteLevel;
        }
        

        #endregion
    }
}
