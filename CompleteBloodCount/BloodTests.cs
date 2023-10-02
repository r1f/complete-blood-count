using System;

namespace CompleteBloodCount
{
    public class BloodTests
    {
        public DateTime testDate;
        public string testName;
        public string diagnosis;
        public BloodTests() 
        {
            this.testDate = DateTime.UtcNow;
        }
        public bool isInTheRange(float value, float[] range)
        {
            if (value <= range[0] && value >= range[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//https://professorweb.ru/my/csharp/thread_and_files/level4/4_5.php