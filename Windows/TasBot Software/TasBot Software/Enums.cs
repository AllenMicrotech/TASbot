using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasBot_Software
{
    public static class Enums
    {
        public enum StartupState {Init,Starting,Loading,Checking,Saving,AwaitingInputConfig,AwaitingInputUpdate,ConfigWizard,Updating,Welcoming,FadingIn};
    }
}
