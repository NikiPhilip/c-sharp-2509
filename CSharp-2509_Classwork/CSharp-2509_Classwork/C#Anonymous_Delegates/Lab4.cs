using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Anonymous_Delegates
{
    public delegate void ProcessCompletedEventHandler(object sender, EventArgs e);

    public class Process
    {
        // Define an event using the delegate
        public event ProcessCompletedEventHandler OnCompleted;

        // Method to start the process
        public void StartProcess()
        {
            Console.WriteLine("Process started...");

            // Simulate process completion
            System.Threading.Thread.Sleep(2000);  // Simulate work by pausing 2 seconds

            // Raise the event after process completion
            OnProcessCompleted();
        }

        // Protected method to raise the event
        protected virtual void OnProcessCompleted()
        {
            // Check if there are any subscribers to the event before raising it
            OnCompleted?.Invoke(this, EventArgs.Empty);
        }





    }
}