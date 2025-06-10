using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public Button btnStart;
    public Button btnRestart;

    private bool isCounting = false;  // �Ƿ��ʱ
    private float countTime = 0; // ��ǰʱ��
    // Start is called before the first frame update
    void Start()
    {
        // �󶨰�ť����¼�
        UIBind.BindClick(btnStart, StartTime);
        UIBind.BindClick(btnRestart, RestartTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            countTime += Time.deltaTime;
            timeText.text = TimeFormatter(countTime);
        }
    }

    string TimeFormatter(float time)
    {
        int hour = (int)time / 3600;
        int min = (int)(time - hour * 3600) / 60;
        int sec = (int)(time - hour * 3600 - min * 60);
        return hour.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
    }

    void StartTime()
    {
        isCounting = !isCounting; // �л���ʱ״̬
    }
    void RestartTime()
    {
        countTime = 0;
        isCounting = true;
    }
}
