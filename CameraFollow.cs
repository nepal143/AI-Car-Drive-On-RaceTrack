using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject FollowCar = null;
    public float FollowSpeed = 3.0f;
    private Transform FollowPos = null;

    private void Start()
    {
        FollowPos = GetChildTransformByName(FollowCar, "FollowPos");
    }
    private void LateUpdate()
    {
        this.transform.LookAt(FollowCar.transform);
        this.transform.position = Vector3.Lerp(this.transform.position, FollowPos.transform.position, Time.deltaTime * FollowSpeed);
    }
    private Transform GetChildTransformByName(GameObject parent, string childname)
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            if (parent.transform.GetChild(i).name == childname)
            {
                return parent.transform.GetChild(i).gameObject.transform;
            }
        }
        return null;
    }
}