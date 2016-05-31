using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class WebNativeDialog : MonoBehaviour {
    [DllImport("__Internal")]
    private static extern string NativeDialogPrompt(string title, string defaultValue);


    public UnityEngine.UI.Text buttonText;

	// Use this for initialization
	void Start () {
	}
    public void OnClickButton()
    {
        string name = NativeDialogPrompt("名前を入力してください", buttonText.text);
        Debug.Log("入力された名前：" + name);
        buttonText.text = name;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
