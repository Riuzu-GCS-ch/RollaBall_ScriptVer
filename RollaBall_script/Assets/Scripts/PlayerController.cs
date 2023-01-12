using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private const float cADD_POWER = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("���������ꂽ��");
            _rigidbody.AddForce(-cADD_POWER, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("�E�������ꂽ��");
            _rigidbody.AddForce(cADD_POWER, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("�オ�����ꂽ��");
            _rigidbody.AddForce(0, 0, cADD_POWER);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("���������ꂽ��");
            _rigidbody.AddForce(0, 0, -cADD_POWER);
        }

    }
}
