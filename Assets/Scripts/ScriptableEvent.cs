using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableEvent : ScriptableObject
{
    [SerializeField] List<EventListenerController> _eventListener;
    public void AddListener(EventListenerController _controller)
    {
        if (_eventListener == null || _eventListener.Count < 0)
            return;

        _eventListener.Add(_controller);
    }

    public void RemoveListener(EventListenerController _controller)
    {
        if (_eventListener == null || _eventListener.Count < 0)
            return;

        _eventListener.Remove(_controller);
    }


    public void RaiseEvent()
    {
        for (int i = 0; i < _eventListener.Count; i++)
        {
            for (int j = 0; j < _eventListener[i].EventListenerStructs.Count; j++)
            {
                if (_eventListener[i].EventListenerStructs[j].ScriptableEvent == this)
                {
                    _eventListener[i].EventListenerStructs[j].UnityEvent.Invoke();
                }
            }
        }
    }

}
