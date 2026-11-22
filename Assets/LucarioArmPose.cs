using UnityEngine;

public class LucarioArmPose : MonoBehaviour
{
    [Header("可手動拖入想微調的子物件（例如 group1 / group2 / paws，可留空）")]
    public Transform targetPart;

    [Header("微調旋轉角度（X, Y, Z）")]
    public Vector3 rotationOffset = Vector3.zero;

    void LateUpdate()
    {
        if (targetPart != null)
        {
            targetPart.localRotation *= Quaternion.Euler(rotationOffset);
        }
    }
}