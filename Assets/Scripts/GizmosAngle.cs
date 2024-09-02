using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using Gizmos = Popcron.Gizmos;

public enum Program{
    treinta = 0,
    veinte = 1,
    diez = 2
}

[ExecuteAlways]
public class AngleOfVision : MonoBehaviour
{

    [SerializeField] private Program _program;
    private List<Vector3> m_Angles;

    // Start is called before the first frame update
    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {

    }
    //void OnDrawGizmos()
    //{
    //    Gizmos.Cone(transform.position, transform.rotation, 10f, 30f, Color.green);
    //    Gizmos.Cone(transform.position, transform.rotation, 10f, 20f, Color.red);
    //    Gizmos.Cone(transform.position, transform.rotation, 10f, 10f, Color.red);
    //}
    private void OnDrawGizmos()
    {
        if (_program.Equals(Program.treinta))
        {
            Gizmos.color = Color.red;
            float rayRange = 0.40f;
            Quaternion rayAngle = Quaternion.AngleAxis(3, Vector3.up);
            Quaternion rayAngle2 = Quaternion.AngleAxis(-3, Vector3.up);
            Vector3 rayDirection1 = rayAngle * transform.forward;
            Vector3 rayDirection2 = rayAngle2 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection1 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection2 * rayRange);

            Quaternion rayAngle3 = Quaternion.AngleAxis(9, Vector3.up);
            Quaternion rayAngle4 = Quaternion.AngleAxis(-9, Vector3.up);
            Vector3 rayDirection3 = rayAngle3 * transform.forward;
            Vector3 rayDirection4 = rayAngle4 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection3 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection4 * rayRange);

            Quaternion rayAngle5 = Quaternion.AngleAxis(15, Vector3.up);
            Quaternion rayAngle6 = Quaternion.AngleAxis(-15, Vector3.up);
            Vector3 rayDirection5 = rayAngle5 * transform.forward;
            Vector3 rayDirection6 = rayAngle6 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection5 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection6 * rayRange);

            Quaternion rayAngleA = Quaternion.AngleAxis(21, Vector3.up);
            Quaternion rayAngleB = Quaternion.AngleAxis(-21, Vector3.up);
            Vector3 rayDirectionA = rayAngleA * transform.forward;
            Vector3 rayDirectionB = rayAngleB * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirectionA * rayRange);
            Gizmos.DrawRay(transform.position, rayDirectionB * rayRange);

            Quaternion rayAngleC = Quaternion.AngleAxis(27, Vector3.up);
            Quaternion rayAngleD = Quaternion.AngleAxis(-27, Vector3.up);
            Vector3 rayDirectionC = rayAngleC * transform.forward;
            Vector3 rayDirectionD = rayAngleD * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirectionC * rayRange);
            Gizmos.DrawRay(transform.position, rayDirectionD * rayRange);

            Quaternion rayAngle7 = Quaternion.AngleAxis(3, Vector3.right);
            Quaternion rayAngle8 = Quaternion.AngleAxis(-3, Vector3.right);
            Vector3 rayDirection7 = rayAngle7 * transform.forward;
            Vector3 rayDirection8 = rayAngle8 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection7 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection8 * rayRange);

            Quaternion rayAngle9 = Quaternion.AngleAxis(9, Vector3.right);
            Quaternion rayAngle0 = Quaternion.AngleAxis(-9, Vector3.right);
            Vector3 rayDirection9 = rayAngle9 * transform.forward;
            Vector3 rayDirection0 = rayAngle0 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection9 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection0 * rayRange);

            Quaternion rayAngle11 = Quaternion.AngleAxis(15, Vector3.right);
            Quaternion rayAngle12 = Quaternion.AngleAxis(-15, Vector3.right);
            Vector3 rayDirection11 = rayAngle11 * transform.forward;
            Vector3 rayDirection12 = rayAngle12 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection11 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection12 * rayRange);

            Quaternion rayAngleF = Quaternion.AngleAxis(21, Vector3.right);
            Quaternion rayAngleG = Quaternion.AngleAxis(-21, Vector3.right);
            Vector3 rayDirectionF = rayAngleF * transform.forward;
            Vector3 rayDirectionG = rayAngleG * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirectionF * rayRange);
            Gizmos.DrawRay(transform.position, rayDirectionG * rayRange);

            Quaternion rayAngleH = Quaternion.AngleAxis(27, Vector3.right);
            Quaternion rayAngleI = Quaternion.AngleAxis(-27, Vector3.right);
            Vector3 rayDirectionH = rayAngleH * transform.forward;
            Vector3 rayDirectionI = rayAngleI * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirectionH * rayRange);
            Gizmos.DrawRay(transform.position, rayDirectionI * rayRange);

        }
        else if (_program.Equals(Program.veinte))
        {
            Gizmos.color = Color.red;
            float rayRange = 5.0f;

            Quaternion rayAngle3 = Quaternion.AngleAxis(20, Vector3.up);
            Quaternion rayAngle4 = Quaternion.AngleAxis(-20, Vector3.up);
            Vector3 rayDirection3 = rayAngle3 * transform.forward;
            Vector3 rayDirection4 = rayAngle4 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection3 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection4 * rayRange);

            Quaternion rayAngle5 = Quaternion.AngleAxis(10, Vector3.up);
            Quaternion rayAngle6 = Quaternion.AngleAxis(-10, Vector3.up);
            Vector3 rayDirection5 = rayAngle5 * transform.forward;
            Vector3 rayDirection6 = rayAngle6 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection5 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection6 * rayRange);

            Quaternion rayAngle9 = Quaternion.AngleAxis(20, Vector3.right);
            Quaternion rayAngle0 = Quaternion.AngleAxis(-20, Vector3.right);
            Vector3 rayDirection9 = rayAngle9 * transform.forward;
            Vector3 rayDirection0 = rayAngle0 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection9 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection0 * rayRange);

            Quaternion rayAngle11 = Quaternion.AngleAxis(10, Vector3.right);
            Quaternion rayAngle12 = Quaternion.AngleAxis(-10, Vector3.right);
            Vector3 rayDirection11 = rayAngle11 * transform.forward;
            Vector3 rayDirection12 = rayAngle12 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection11 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection12 * rayRange);
        }
        else if (_program.Equals(Program.diez))
        {
            Gizmos.color = Color.red;
            float rayRange = 5.0f;

            Quaternion rayAngle5 = Quaternion.AngleAxis(10, Vector3.up);
            Quaternion rayAngle6 = Quaternion.AngleAxis(-10, Vector3.up);
            Vector3 rayDirection5 = rayAngle5 * transform.forward;
            Vector3 rayDirection6 = rayAngle6 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection5 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection6 * rayRange);

            Quaternion rayAngle11 = Quaternion.AngleAxis(10, Vector3.right);
            Quaternion rayAngle12 = Quaternion.AngleAxis(-10, Vector3.right);
            Vector3 rayDirection11 = rayAngle11 * transform.forward;
            Vector3 rayDirection12 = rayAngle12 * transform.forward;
            Gizmos.DrawRay(transform.position, rayDirection11 * rayRange);
            Gizmos.DrawRay(transform.position, rayDirection12 * rayRange);
        }
    }
}