using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /* Initial the values of the variabel REAR and FRONT to -1 
             *  to indicate the queue is initially empty.*/
            FRONT = -1;
            REAR = -1;

        }
        public void insert(int element)
        {
            /* This statment check for the overflow condition. */
            if ((FRONT == 0 && REAR == max -1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* The following statment checks whether the queue is empty. if the\* queue is
             * *empty, then the value of the REAR and FRONT variables is set to 0.*/
            if (FRONT ==-1)
            { 
                
            }
        }
    }
}
   