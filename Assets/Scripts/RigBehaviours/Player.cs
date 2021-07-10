using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float teleportationDleay = 0;

    public Transform target;

    public Teleportation teleportationBehaviour;
    public LinearMovement linearMovementBehaviour;
    public RotationUIButtons RotationUIBehaviour;


    public GameObject playerUI;
    public GameObject returnToGame;
    public GameObject rig;
    public Rigidbody rb;

    private void Awake()
    {
        teleportationBehaviour = new Teleportation(this.transform);

        linearMovementBehaviour = new LinearMovement(this.transform, transform.GetChild(0));

        RotationUIBehaviour = new RotationUIButtons(transform.GetChild(1), transform.GetChild(0));

        rb = GetComponent<Rigidbody>();
    }

    public void StartMoving()
    {
        linearMovementBehaviour.SetSpeed(0.08f);
    }

    public void StopMoving()
    {
        linearMovementBehaviour.SetSpeed(0);
        rb.velocity = Vector3.zero;
    }
    public void Start()
    {
        RotationUIBehaviour.CalculateOffSet();
    }


    private void Update()
    {
        linearMovementBehaviour.Move();
        
    }
    private void LateUpdate()
    {
        RotationUIBehaviour.GetRotation();
    }
    public void TeleportToSphere(Transform sphere)
    {
        //Debug.Log("Active? " + gameObject.activeInHierarchy);
        //if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //    Debug.Log("Active? " + base.gameObject.activeInHierarchy);
        //}

        target = sphere;

        StartCoroutine(WaitToTeleport());
    }


    public IEnumerator WaitToTeleport()
    {
        yield return new WaitForSeconds(teleportationDleay);

        teleportationBehaviour.Teleport(target);
    }
}
