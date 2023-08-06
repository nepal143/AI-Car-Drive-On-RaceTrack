using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Checkpoints))]
public class CheckpointsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Checkpoints script = (Checkpoints)target;

        GUI.backgroundColor = Color.yellow;
        if (GUILayout.Button("Angle Size Checkpoint Walls") == true)
        {
            script.AngleSizeCheckpointWalls();
        }

        GUILayout.Label(script.Description());
    }
}