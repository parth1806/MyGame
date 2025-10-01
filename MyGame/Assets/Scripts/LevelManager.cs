using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    [SerializeField] private Card cardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCards();
    }

    private void SpawnCards()
    {
        var rows = 2;
        var columns = 3;


        gridLayoutGroup.constraintCount = rows;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                var cell = i * columns + j;
                var card = Instantiate(cardPrefab, gridLayoutGroup.transform);

            }
        }
    }
}
