using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BEEnance.Helpers
{
    public interface IEnvironment
    {
        void SetStatusBarColor(Color color, bool darkStatusBarTint);
    }
}
