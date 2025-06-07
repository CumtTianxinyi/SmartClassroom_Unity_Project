using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TeacherBehavior : MonoBehaviour
{
    public Transform whiteboardSpot; // 白板旁位置
    public TextMeshProUGUI whiteboardText;    // 白板上的 UI 文本组件
    public float speed = 2f;         // 移动速度
    public string[] speechLines;     // 要说的话内容数组

    private int currentLine = 0;
    private bool isSpeaking = false;

    void Update()
    {
        // 按下 T 键触发教师走到白板 + 说话
        if (Input.GetKeyDown(KeyCode.T) && !isSpeaking)
        {
            StartCoroutine(MoveToWhiteboardAndSpeak());
        }
    }

    // 协程：移动 → 显示对白
    System.Collections.IEnumerator MoveToWhiteboardAndSpeak()
    {
        isSpeaking = true;

        // 自动朝向白板方向旋转
        Vector3 targetPos = whiteboardSpot.position;
        while (Vector3.Distance(transform.position, targetPos) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            transform.LookAt(new Vector3(targetPos.x, transform.position.y, targetPos.z));
            yield return null;
        }

        // 开始说话：每隔 2 秒说一句
        for (int i = 0; i < speechLines.Length; i++)
        {
            whiteboardText.text = speechLines[i];
            yield return new WaitForSeconds(2f);
        }

        whiteboardText.text = ""; // 清空
        isSpeaking = false;
    }
}
