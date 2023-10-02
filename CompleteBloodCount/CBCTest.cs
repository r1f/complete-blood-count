using System;

namespace CompleteBloodCount
{
    public class CBCTest : BloodTests
    {
        internal float[] _whiteBloodCellRange = { 3.4F, 9.6F };
        internal float[] _redBloodCellMaleRange = { 4.35F, 5.65F };
        internal float[] _redBloodCellFemaleRange = { 3.92F, 5.13F };
        internal float[] _hemoglobinMaleRange = { 13.2F, 5.13F };
        internal float[] _hemoglobinFemaleRange = { 11.6F, 15F };
        internal float[] _hematocritMaleRange = { 38.3F, 48.6F };
        internal float[] _hematocritFemaleRange = { 35.5F, 44.9F };
        internal float[] _plateletCountMaleRange = { 135F, 317F };
        internal float[] _plateletCountFemaleRange = { 157F, 371F };
        internal string[] diagnosisRange = {
                "Bone marrow problems; Cancer; Infection; Inflammation; Immune system disorder.",
                "Anemia; Polycythemia vera; Heart disease.",
                "Infection; Leukemia"
        };
        public float WhiteBloodCells;
        public float RedBloodCells;
        public float HemoglobinContent;
        public float Hematocrit;
        public float PlateletCount;
        public CBCTest(float WBC, float RBC, float hb, float hct, float PC)
        {
            this.testName = "CBC test";
            WhiteBloodCells = WBC;
            RedBloodCells = RBC;
            HemoglobinContent = hb;
            Hematocrit = hct;
            PlateletCount = PC;
            this.diagnosis = "Preliminary results: " + CBCTestResult();
        }
        public CBCTest() { }
        public string CBCTestResult()
        {
            Person person = new Person();
            person = person.getPerson();
            if (person.Gender)
            {
                if (!isInTheRange(WhiteBloodCells, _whiteBloodCellRange))
                    return diagnosisRange[0];
                if (!isInTheRange(RedBloodCells, _redBloodCellMaleRange) && !isInTheRange(HemoglobinContent, _hemoglobinMaleRange) && !isInTheRange(Hematocrit, _hematocritMaleRange))
                    return diagnosisRange[1];
                if (!isInTheRange(PlateletCount, _plateletCountMaleRange))
                    return diagnosisRange[2];
            }
            else
            {
                if (!isInTheRange(WhiteBloodCells, _whiteBloodCellRange))
                    return diagnosisRange[0];
                if (!isInTheRange(RedBloodCells, _redBloodCellFemaleRange) && !isInTheRange(HemoglobinContent, _hemoglobinFemaleRange) && !isInTheRange(Hematocrit, _hematocritFemaleRange))
                    return diagnosisRange[1];
                if (!isInTheRange(PlateletCount, _plateletCountFemaleRange))
                    return diagnosisRange[2];
            }
            return null;
        }
    }
}
