using System;

namespace BlazorRadesWeb.Model
{
    public class CalibrationCase
    {
        public string State { get; set; }

        public DateTime CreateDate { get; set; }

        public int Id { get; set; }

        public string SectionCategory { get; set; }

        public string MyProperty { get; set; }

        public int Material { get; set; }

        public int Surface { get; set; }

        public int ToothNumber { get; set; }

        public string UploadedBy { get; set; }


    }
}