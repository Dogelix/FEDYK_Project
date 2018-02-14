using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class PlayerController : NetworkBehaviour
{
    public Camera playerCam;
    public GameObject gunPosition;

    public float speed;
    public float jumpSpeed;
    public float gravity;

    private Vector3 moveDirection = Vector3.zero;
    private float speedRef;

    public GameObject endOfGun;

    private Pistol testPistol;

    void Start()
    {
        speedRef = speed;
        if (isLocalPlayer)
        {
            testPistol = gameObject.AddComponent<Pistol>();
            return;
        }

        playerCam.enabled = false;
    }

    void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetButton("Walk"))
        {
            speed = speedRef / 2;
        }
        else
        {
            speed = speedRef;
        }

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        //else
        //{
        //    moveDirection.x = Input.GetAxis("Horizontal") * speed;
        //    moveDirection.z = Input.GetAxis("Vertical") * speed;
        //}

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        gunPosition.transform.forward = new Vector3(playerCam.transform.forward.x, playerCam.transform.forward.y, playerCam.transform.forward.z);

        if (Input.GetButtonDown("Fire1"))
        {
            testPistol.InstantiateRaycast(endOfGun.transform.position, playerCam);
        }
    }
}
