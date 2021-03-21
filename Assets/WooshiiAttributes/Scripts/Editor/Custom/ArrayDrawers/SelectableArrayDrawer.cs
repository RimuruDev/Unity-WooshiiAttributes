﻿using System;
using UnityEditor;
using UnityEngine;

namespace WooshiiAttributes
    {
    public class SelectableArrayDrawer : ArrayDrawer<SelectableArrayAttribute>
        {
        private static Texture2D AddTex => EditorGUIUtility.Load ("icons/d_winbtn_mac_max_h.png") as Texture2D;
        private static Texture2D RemoveTex => EditorGUIUtility.Load ("icons/d_winbtn_mac_min_h.png") as Texture2D;

        private int selection;

        public SelectableArrayDrawer(SerializedObject parent, SerializedProperty property) : base(parent, property)
            {
            
            }

        protected override void OnGUI_Internal()
            {

            //SerializedObject serializedObject = property.serializedObject;
            //if (!property.isArray)
            //    {
            //    Debug.LogWarning ("Attribute of type SelectableArray is not required on field " + property.displayName);
            //    EditorGUILayout.PropertyField (property);
            //    return;
            //    }

            //string[] names = new string[property.arraySize];

            //EditorGUILayout.LabelField (property.displayName);

            //if (property.arraySize == 0)
            //    {
            //    DrawButtonLabel (AddTex, "Add Element", () =>
            //    {
            //        property.InsertArrayElementAtIndex (0);

            //        serializedObject.ApplyModifiedProperties ();
            //        serializedObject.Update ();
            //    });

            //    return;
            //    }
            //else
            //    {
            //    EditorGUILayout.BeginHorizontal ();
            //        {
            //        DrawButtonLabel (AddTex, "Add Element", () =>
            //        {
            //            property.InsertArrayElementAtIndex (property.arraySize);

            //            serializedObject.ApplyModifiedProperties ();
            //            serializedObject.Update ();
            //        });

            //        DrawButtonLabel (RemoveTex, "Remove Element", () =>
            //        {
            //            property.DeleteArrayElementAtIndex (0);
            //            selection = Mathf.Clamp (selection, 0, property.arraySize);

            //            serializedObject.ApplyModifiedProperties ();
            //            serializedObject.Update ();
            //        });
            //        }
            //    EditorGUILayout.EndHorizontal ();
            //    }

            //for (int i = 0; i < names.Length; i++)
            //    names[i] = property.GetArrayElementAtIndex (i).displayName;

            //EditorGUILayout.LabelField ("Selection (" + property.arraySize + ")");

            //int val;
            //EditorGUI.BeginChangeCheck ();
            //    {
            //    int width = Mathf.Min (4, names.Length);
            //    val = selection = GUILayout.SelectionGrid (selection, names, 3);
            //    }
            //if (EditorGUI.EndChangeCheck ())
            //    {
            //    serializedObject.ApplyModifiedProperties ();
            //    serializedObject.Update ();
            //    }

            //EditorGUILayout.PropertyField (property.GetArrayElementAtIndex (val));

            }

        private bool DrawButtonLabel(Texture2D texture, string label, System.Action action)
            {

            bool pressed = false;
            GUILayout.BeginVertical ();
                {
                if (pressed = GUILayout.Button (texture, EditorStyles.centeredGreyMiniLabel))
                    action?.Invoke ();
                else
                if (!string.IsNullOrWhiteSpace (label))
                    if (pressed = GUILayout.Button (label, EditorStyles.centeredGreyMiniLabel))
                        action?.Invoke ();
                }
            GUILayout.EndVertical ();

            return pressed;
            }
        }
    }
