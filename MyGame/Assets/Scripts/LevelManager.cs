using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    [SerializeField] private Card cardPrefab;

    public Sprite[] cardSprites;
    private int[] _shuffledCardsIndex;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCards();
    }

    private void SpawnCards()
    {
        var rows = 2;
        var columns = 3;

        _shuffledCardsIndex = new int[rows * columns];
        for (var i = 0; i < _shuffledCardsIndex.Length; i++)
        {
            _shuffledCardsIndex[i] = i / 2; // Setup pair of cards.
        }

        gridLayoutGroup.constraintCount = rows;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                var cell = i * columns + j;
                var card = Instantiate(cardPrefab, gridLayoutGroup.transform);
                var cardId = _shuffledCardsIndex[cell];
                var frontImage = cardSprites[cardId];
                card.Setup(frontImage);
            }
        }
    }
}
