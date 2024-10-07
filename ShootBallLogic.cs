using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButton;
    }

    private void ShootBallOnButton()
    {
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;


        GameObject spawnedBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();


        if (rb != null)
        {
            rb.AddForce(mainCam.transform.forward * ballForwardForce);
        }
        
        Destroy(spawnedBall, 5f);
    }
}
