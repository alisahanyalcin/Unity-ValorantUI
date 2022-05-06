using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace alisahanyalcin
{
    public class EventAction : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {
        private enum Event
        {
            None,
            PointerEnter,
            PointerExit,
            PointerDown,
            PointerUp,
            Click,
            DoubleClick
        }

        [SerializeField] private Event eventType = Event.None;
        [SerializeField] private UnityEngine.Events.UnityEvent @event;

        private bool _mPressed = false;

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (!this._mPressed)
                this.TriggerEvent(Event.PointerEnter);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (!this._mPressed)
                this.TriggerEvent(Event.PointerExit);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            this.TriggerEvent(Event.PointerDown);

            this._mPressed = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            this.TriggerEvent(Event.PointerUp);

            if (this._mPressed)
            {
                if (eventData.clickCount > 1)
                {
                    this.TriggerEvent(Event.DoubleClick);
                    eventData.clickCount = 0;
                }
                else
                    this.TriggerEvent(Event.Click);
            }

            this._mPressed = false;
        }

        private void TriggerEvent(Event e)
        {
            if (e == this.eventType)
                @event.Invoke();
        }
    }
}
