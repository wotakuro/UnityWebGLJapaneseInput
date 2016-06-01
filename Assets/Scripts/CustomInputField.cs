using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class CustomInputField : UnityEngine.UI.InputField
{
    public string dialogTitle = "Input Text";

#if UNITY_WEBGL && !UNITY_EDITOR

    public override void OnSelect(BaseEventData eventData)
    {
        this.text = WebNativeDialog.OpenNativeStringDialog(dialogTitle, this.text);
        this.text = "aa";
        this.DeactivateInputField();
    }
    
#endif
}
