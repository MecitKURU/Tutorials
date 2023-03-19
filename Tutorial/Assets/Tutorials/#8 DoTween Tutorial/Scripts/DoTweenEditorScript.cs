using UnityEditor;
using DG.Tweening;
using UnityEngine;

[CustomEditor(typeof(DoTweenEditorManager))]
public class DoTweenEditorScript : Editor
{
    static int jumpVal;
    static int jumpNumberVal;
    static Vector3 jumpEndPoint;
    string[] _choices = new[] { "Jump", "Scale" };
    string[] _jumpChoices = new[] { "Scale Value", "Scale" };
    int _choiceIndex = 0;
    public override void OnInspectorGUI()
    {
        DoTweenEditorManager doTweenEditorManager = (DoTweenEditorManager)target;
        // Draw the default inspector
        DrawDefaultInspector();

        if (_choiceIndex < 0)
            _choiceIndex = 0;

        _choiceIndex = EditorGUILayout.Popup(_choiceIndex, _choices);

        if (_choiceIndex == 1)
        {
            jumpEndPoint = EditorGUILayout.Vector3Field("Jump Target Point", jumpEndPoint);
            jumpVal = EditorGUILayout.IntSlider("Jump Value", jumpVal, 1, 10);
            jumpNumberVal = EditorGUILayout.IntSlider("Jump Number", jumpNumberVal, 1, 10);

            if (GUILayout.Button("Jump Button"))
            {
              //  doTweenEditorManager.JumpObj(jumpEndPoint, jumpVal, jumpNumberVal, 1);
                Debug.Log("Clicked the jump");
            }

        }
        // EditorGUILayout.Popup()
    }
}
