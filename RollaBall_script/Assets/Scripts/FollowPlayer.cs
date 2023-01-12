using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = _player.transform.position + _offset;
    }
}
