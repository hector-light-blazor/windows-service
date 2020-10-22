using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace SpartanE_Sign_Service
{
    public partial class ServiceSpartanE : ServiceBase
    {
    
        public ServiceSpartanE()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // First Make sure the exe is not running.
            try
            {

                onCheckProcess();
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "ServiceFiles/microservice-letter.exe");
                
               

            }
            finally {

               
            }
            
           
        }


        protected override void OnStop()
        {
            try {
                onCheckProcess();

            } finally { }
            
        }

        public void onCheckProcess() {
            Process[] pList = Process.GetProcessesByName("microservice-letter");

            foreach (Process p in pList)
            {
                
                p.Kill();
               
            }
        }

    }
}
