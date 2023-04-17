using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;

public class PanelLevelOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textBronzeCoinMax;
    [SerializeField] private TextMeshProUGUI _textSilverCoinMax;
    [SerializeField] private TextMeshProUGUI _textGoldCoinMax;
    
    private void Update()
    {
        _textBronzeCoinMax.text = $"{PlayerTouch.bronzeCoin}/{PlayerTouch.bronzeCoinMax}";
        _textSilverCoinMax.text = $"{PlayerTouch.silverCoin}/{PlayerTouch.silverCoin}";
        _textGoldCoinMax.text = $"{PlayerTouch.goldCoin}/{PlayerTouch.goldCoin}";
    }
}
