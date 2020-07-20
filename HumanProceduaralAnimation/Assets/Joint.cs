using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    public Vector3 angle;
    Vector3 offset;

private void Awake() {
    offset=transform.localPosition;
}
}
