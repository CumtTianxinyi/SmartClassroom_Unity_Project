using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TeacherBehavior : MonoBehaviour
{
    public Transform whiteboardSpot; // �װ���λ��
    public TextMeshProUGUI whiteboardText;    // �װ��ϵ� UI �ı����
    public float speed = 2f;         // �ƶ��ٶ�
    public string[] speechLines;     // Ҫ˵�Ļ���������

    private int currentLine = 0;
    private bool isSpeaking = false;

    void Update()
    {
        // ���� T ��������ʦ�ߵ��װ� + ˵��
        if (Input.GetKeyDown(KeyCode.T) && !isSpeaking)
        {
            StartCoroutine(MoveToWhiteboardAndSpeak());
        }
    }

    // Э�̣��ƶ� �� ��ʾ�԰�
    System.Collections.IEnumerator MoveToWhiteboardAndSpeak()
    {
        isSpeaking = true;

        // �Զ�����װ巽����ת
        Vector3 targetPos = whiteboardSpot.position;
        while (Vector3.Distance(transform.position, targetPos) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            transform.LookAt(new Vector3(targetPos.x, transform.position.y, targetPos.z));
            yield return null;
        }

        // ��ʼ˵����ÿ�� 2 ��˵һ��
        for (int i = 0; i < speechLines.Length; i++)
        {
            whiteboardText.text = speechLines[i];
            yield return new WaitForSeconds(2f);
        }

        whiteboardText.text = ""; // ���
        isSpeaking = false;
    }
}
