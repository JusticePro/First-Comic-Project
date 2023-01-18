using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace First_Comic_Project
{
    public interface EpisodeSelection
    {

        /***
         * Return null to cancel gathering.
         */
        IEnumerable<int> getEpisodes();
        
    }
}
