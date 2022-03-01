using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [Range(0, 100)]
    public int XForce;

    public Transform FrontBogieTarget;
    public Transform BackBogieTarget;

    public Transform FrontBogieTransform;
    public Transform BackBogieTransform;

    public Transform FrontBogieGoal;

    // Start is called before the first frame update
    void Start()
    {
        //FrontBogieTransform.position = FrontBogieGoal.position;

        Vector3 direction = FrontBogieTransform.position - BackBogieTarget.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, direction);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(XForce * Time.deltaTime, 0, 0);

    }
}
