using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UIBind : MonoBehaviour
{
    /// <summary>
    /// ��ť��
    /// </summary>
    /// <param name="button"></param>
    /// <param name="callback"></param>
    public static void BindClick(Button button, UnityEngine.Events.UnityAction callback)
    {
        button.onClick.AddListener(callback);
    }

    /// <summary>
    /// ��ѡ��ť��
    /// </summary>
    /// <param name="tg"></param>
    /// <param name="callback"></param>
    public static void BindSelected(Toggle tg, UnityEngine.Events.UnityAction<bool> callback)
    {
        tg.onValueChanged.AddListener(callback);
    }

    /// <summary>
    /// ����������
    /// </summary>
    /// <param name="input"></param>
    /// <param name="callback"></param>
    public static void BindInputted(InputField input, UnityEngine.Events.UnityAction<string> callback)
    {
        input.onEndEdit.AddListener(callback);
    }

    /// <summary>
    /// �����ֵ�仯��
    /// </summary>
    /// <param name="input"></param>
    /// <param name="callback"></param>
    public static void BindInputChanged(InputField input, UnityEngine.Events.UnityAction<string> callback)
    {
        input.onValueChanged.AddListener(callback);
    }

    /// <summary>
    /// ������ѡ���
    /// </summary>
    /// <param name="dropdown"></param>
    /// <param name="callback"</param>
    public static void BindDropDown(Dropdown dropdown, UnityEngine.Events.UnityAction<int> callback)
    {
        dropdown.onValueChanged.AddListener(callback);
    }

}
