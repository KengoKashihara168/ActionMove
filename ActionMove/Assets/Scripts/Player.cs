using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Move _move;

    // Start is called before the first frame update
    void Start()
    {
        _move = GetComponent<Move>();
        _move.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _move.Moving();
    }
}
