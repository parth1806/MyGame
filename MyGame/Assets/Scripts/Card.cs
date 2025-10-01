using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    private Image _cardImage;


    private void Awake()
    {
        _cardImage = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setup( Sprite frontImage)
    {
        _cardImage.sprite = frontImage;
    }
}
