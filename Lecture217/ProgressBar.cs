using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture217
{
    internal class ProgressBar
    {
        public ProgressBar(int progress = 0)
        {
            Progress = progress;
        }

        public int Progress { get; set; }

        public async Task MoveProgressAsync()
        {
            while (this.Progress < 100)
            {
                Progress += 1;
                await Task.Delay(100);
            }
        }

    }
}
