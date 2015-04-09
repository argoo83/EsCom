using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace EsComClient.Workers
{
    public class MainWorker
    {
        public void Initiate()
        {
            bool stop = false;
            Timer t = new Timer(5000);
            t.Start();
            t.Elapsed += t_Elapsed;
        }

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

    }
}
