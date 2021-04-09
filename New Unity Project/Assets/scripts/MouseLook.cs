using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] public List<string> selectableTags;
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if ((hit.transform != null) && (selectableTags.Contains(hit.transform.gameObject.tag)))
            {
                FindObjectOfType<ChangingColor>().MouseOverColor();
            } else
            {
                FindObjectOfType<ChangingColor>().RegularColor();
            }
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
