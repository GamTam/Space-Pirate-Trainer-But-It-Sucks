using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerOptions : MonoBehaviour
{
    [SerializeField] private GameObject[] _guns;
    [SerializeField] private GameObject[] _shields;

    private bool _leftHand = true;
    private PlayerInput _input;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
    }

    public void SwitchHand()
    {
        _leftHand = !_leftHand;
        
        if (_leftHand)
        {
            _guns[0].SetActive(true);
            _shields[0].SetActive(false);
            _guns[1].SetActive(false);
            _shields[1].SetActive(true);
            
            _input.SwitchCurrentActionMap("XRI LeftHand Interaction");
        }
        else
        {
            _guns[0].SetActive(false);
            _shields[0].SetActive(true);
            _guns[1].SetActive(true);
            _shields[1].SetActive(false);
            
            _input.SwitchCurrentActionMap("XRI RightHand Interaction");
        }
    }
}
