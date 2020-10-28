using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* @author $Safa Arooj$
*/

namespace TTS_server_alap_alpha_v1
{
    class TTSProperties
    {
        public static readonly string MSG_PDF_MODE_ENABLED = "PDF Mode enabled!";
        public static readonly string MSG_TTS_PAUSED = "TTS Paused!";
        public static readonly string MSG_TTS_RESUMED = "TTS Resumed!"; 
        public static readonly string MSG_SPEED_INCREASED = "Speed Increased";
        public static readonly string MSG_SPEED_DECREASED = "Speed Decreased";
        public static readonly string MSG_VOICE_CHANGED = "Voice Changed";
        public static readonly string CMND_KILL_TTS = "/C TASKKILL /F /IM TTS_server_alap_alpha_v1.exe";
    }
}
