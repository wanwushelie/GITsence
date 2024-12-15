using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 角色移动速度
    public Camera followCamera;   // 跟随的摄像机
    public Vector3 cameraOffset;  // 摄像机相对于角色的偏移量

    void Update()
    {
        // 获取输入
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D 或 左/右箭头
        float moveVertical = Input.GetAxis("Vertical");     // W/S 或 上/下箭头

        // 计算角色移动方向
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // 更新摄像机位置
        UpdateCameraPosition();
    }

    void UpdateCameraPosition()
    {
        if (followCamera != null)
        {
            // 摄像机跟随角色
            followCamera.transform.position = transform.position + cameraOffset;
            followCamera.transform.LookAt(transform.position); // 可选：摄像机始终朝向角色
        }
    }
}
