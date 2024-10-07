using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;
    // Start is called before the first frame update
    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += OnStartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked += OnResetButtonClicked;
        
    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }

    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }


}
