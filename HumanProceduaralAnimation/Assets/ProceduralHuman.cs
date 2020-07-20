using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralHuman : MonoBehaviour
{
    [SerializeField] GameObject neck;
    [SerializeField] GameObject target;

    [SerializeField] float speed=1;

    [SerializeField] float maxAngle=75;
    


    private void LateUpdate() {
        Quaternion currentLocalRotation=neck.transform.localRotation;
        neck.transform.localRotation=Quaternion.identity;
        
        Vector3 worldTargetdirection=target.transform.position-neck.transform.position;
        Vector3 localTargetdirection= neck.transform.InverseTransformDirection(worldTargetdirection);

        localTargetdirection=Vector3.RotateTowards(Vector3.forward,localTargetdirection,Mathf.Deg2Rad*maxAngle,0);


        Quaternion targetRotation=Quaternion.LookRotation(localTargetdirection,Vector3.up);
        neck.transform.localRotation=Quaternion.Slerp(currentLocalRotation,targetRotation,1-Mathf.Exp(-speed*Time.deltaTime));
    }

}
