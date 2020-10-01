using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.TimeSessions
{
    public class SlotsList
    {
        public int[] slots;

        public SlotsList() { }

        public  SlotsList(int noOfSlots)
        {
            this.slots = new int[noOfSlots];
            initializedArray();
        }


        public void initializedArray()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                slots[i] = -1;
            }


        }

        public int[] getSlot()
        {
            return this.slots;
        }

    }
}
