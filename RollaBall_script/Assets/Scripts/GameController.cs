using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _scoreLabel;
    [SerializeField] private GameObject _winnerLabelObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;

        _scoreLabel.text = count.ToString();

        if (count == 0)
        {
            _winnerLabelObject.SetActive(true);
        }
    }
}
