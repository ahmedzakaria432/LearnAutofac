using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Application : IApplication
    {
        private readonly IBusinessLogic logic;

        public Application(IBusinessLogic logic)
        {
            this.logic = logic;
        }
        public void Run()
        {
            logic.ProcessData();
        }
    }
}
