using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class Gravity : MonoBehaviour
{
    public XROrigin rig;
    public LayerMask groundLayer;
    CharacterController character;
    float fallSpeed;
    public float gravity = -9.8f;
    void Start()
    {
        character = rig.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        bool isGrounded = CheckIfGround();
        if (isGrounded)
            fallSpeed = 0f;
        else
            fallSpeed += gravity * Time.fixedDeltaTime;

        character.Move(Vector3.up * fallSpeed * Time.fixedDeltaTime);
    }

    bool CheckIfGround()
    {
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;

        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
}
