using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMultipleWorlds
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
