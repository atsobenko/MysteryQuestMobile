using UnityEngine;

namespace Objects.ActiveObject
{
    public class ActiveObjectState : MonoBehaviour
    {
        public string stateName;
        public string stateDescription;
        public string methodName;
        public Item.Item requiredItem;
    }
}
