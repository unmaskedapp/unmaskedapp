using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnmaskedApp.Client.Code.Events
{
    public class MouseClickHandler
    {
        public event Action OnBodyClick;

        public void InvokeBodyClick()
        {
            OnBodyClick?.Invoke();
        }
    }
}
