using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Objects.Teleport
{
    public class DraggablePoint : PropertyAttribute { }

#if UNITY_EDITOR
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class DraggablePointDrawer : Editor
    {

        readonly GUIStyle _style = new GUIStyle();

        private void OnEnable()
        {
            _style.fontStyle = FontStyle.Bold;
            _style.normal.textColor = Color.white;
        }

        public void OnSceneGUI()
        {
            var property = serializedObject.GetIterator();
            while (property.Next(true))
            {
                if (property.propertyType != SerializedPropertyType.Vector3)
                {
                    continue;
                }
                
                var field = serializedObject.targetObject.GetType().GetField(property.name);
                
                if (field == null)
                {
                    continue;
                }
                
                var draggablePoints = field.GetCustomAttributes(typeof(DraggablePoint), false);
                
                if (draggablePoints.Length <= 0)
                {
                    continue;
                }
                
                Handles.Label(property.vector3Value, property.name);
                property.vector3Value = Handles.PositionHandle(property.vector3Value, Quaternion.identity);
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
#endif
}