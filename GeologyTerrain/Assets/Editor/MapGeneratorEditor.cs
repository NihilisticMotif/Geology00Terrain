using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
// No one can drag Editor Script to Unity Game Object.
// In order to attach Editor script, you have to code
// [CustomEditor(typeof( .../* Name-of-Script */...))]
public class MapGeneratorEditor : Editor
{
	public override void OnInspectorGUI()
	{
		
		MapGenerator mapGen = (MapGenerator)target;

		if (DrawDefaultInspector())
		{
			if (mapGen.autoUpdate)
			{
				mapGen.GenerateMap();
			}
		}
		
	
		if (GUILayout.Button("Generate"))
		{
			mapGen.GenerateMap();
		}
	}
}